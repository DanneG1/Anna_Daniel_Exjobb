﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using ReadDllForm.Properties;

namespace ReadDllForm
{
    public class CreateDll
    {
        private const string Solution = "Solution";
        private const string MsBuild = "MsBuild";
        private const string TargetFolder = "TargetFolder";
        private const string ExampleFilePath = @"..\..\files\exampleCppDLL.txt";
        private static readonly string SolutionFileName = Settings.Default["Solution"].ToString();
        private static readonly string SolutionDirectory = Path.GetDirectoryName(SolutionFileName);
        private static readonly string TargetFileName = $@"{SolutionDirectory}{"\\GenerateDLL\\GenerateDLL.cpp"}";

        private static string _hPath;
        private static string _cppPath;
        private static string _referenceInput;
        private static string _referenceOutput;
        private static string _modelName;
        private static string _modelFolderName;
        private static string _modelDllName;

        public static List<string> Inputs = new List<string>();
        public static List<string> Outputs = new List<string>();

        public void CreateFile(string hPath, string cppPath, string modelFolderName)
        {
            _hPath = hPath;
            _cppPath = cppPath;
            _modelFolderName = modelFolderName;
            _modelDllName = modelFolderName + ".dll";
            FindIO();
            FormatIO();
            GenerateCppFile();
            CreateModelDll();
            ResetIOLists();
        }

        private static IEnumerable<String> ReadFile()
        {
            IEnumerable<String> lines = File.ReadLines(_hPath);
            return lines;
        }
        private static void FindIO()
        {
            Boolean foundInputs = false;
            Boolean foundOutputs = false;
            Boolean foundConstructor = false;
            Regex inputRegex = new Regex("(.*)ExtU(.*)");
            Regex outputRegex = new Regex("(.*)ExtY(.*)");

            IEnumerable<String> lines = ReadFile();

            foreach (var line in lines)
            {
                Match inputMatch = inputRegex.Match(line);
                Match outputMatch = outputRegex.Match(line);


                if (line.Contains("External inputs") || foundInputs.Equals(true))
                {
                    if (foundInputs.Equals(false))
                    {
                        foundInputs = true;
                        continue;
                    }
                    if (line.Contains("}"))
                    {
                        foundInputs = false;
                        continue;
                    }
                    if (line.Contains("<Root>") && line.Contains("//"))
                        Inputs.Add(line);

                }
                else if (line.Contains("External outputs") || foundOutputs.Equals(true))
                {
                    if (foundOutputs.Equals(false))
                    {
                        foundOutputs = true;
                        continue;
                    }
                    if (line.Contains("}"))
                    {
                        foundOutputs = false;
                        continue;
                    }
                    if (line.Contains("<Root>") && line.Contains("//"))
                        Outputs.Add(line);
                }
                if (line.Contains("Constructor") || foundConstructor)
                {
                    if (!foundConstructor)
                        foundConstructor = true;
                    else
                    {
                        string[] splitLine = line.Split('(');
                        _modelName = splitLine[0];
                        foundConstructor = false;
                    }
                }
                if (inputMatch.Success)
                {
                    string[] splitLine = line.Split(' ');
                    _referenceInput = splitLine[3];
                    _referenceInput = _referenceInput.Replace(';', '.');
                    System.Console.WriteLine(_referenceInput);
                }
                if (outputMatch.Success)
                {
                    string[] splitLine = line.Split(' ');
                    _referenceOutput = splitLine[3];
                    _referenceOutput = _referenceOutput.Replace(';', '.');

                    System.Console.WriteLine(_referenceOutput);
                }
            }

        }
        private static void FormatIO()
        {
            List<string> newInputs = new List<string>();
            List<string> newOutputs = new List<string>();

            foreach (var input in Inputs)
            {
                string[] inputArr = input.Split(' ');
                inputArr[3] = inputArr[3].Replace(';', ' ');
                newInputs.Add(inputArr[3]);

            }
            foreach (var output in Outputs)
            {
                string[] outputArr = output.Split(' ');
                outputArr[3] = outputArr[3].Replace(';', ' ');
                newOutputs.Add(outputArr[3]);
            }
            Inputs = newInputs;
            Outputs = newOutputs;
        }
        private static void GenerateCppFile()
        {
            IEnumerable<String> lines = File.ReadLines(ExampleFilePath);
            List<String> newContent = new List<String>();


            foreach (var line in lines)
            {
                //Sätt paths till .h och .cpp fil
                if (line.Contains("!.h "))
                {
                    newContent.Add("#include \"" + _hPath + "\"");
                }
                else if (line.Contains(" !.cpp "))
                {
                    newContent.Add("#include \"" + _cppPath + "\"");
                }

                //Skapa modellen
                else if (line.Contains("!modelName"))
                {
                    newContent.Add(_modelName + " rObj;");
                }

                //Skapa switch case för setInputs
                else if (line.Contains("!setInputCase"))
                {
                    for (int i = 0; i < Inputs.Count(); ++i)
                    {
                        newContent.Add("case " + i + ":");
                        newContent.Add("rObj." + _referenceInput + Inputs[i] + "= value;");
                        newContent.Add("break;");
                    }
                }

                //Skapa switch case för getOutputs
                else if (line.Contains("!getOutputCase"))
                {
                    for (int i = 0; i < Outputs.Count(); ++i)
                    {
                        newContent.Add("case " + i + ":");
                        newContent.Add(" return rObj." + _referenceOutput + Outputs[i] + ";");
                    }
                }
                else if (line.Contains("!getInputCase"))
                {
                    for (int i = 0; i < Inputs.Count(); ++i)
                    {
                        newContent.Add("case " + i + ":");
                        newContent.Add(" return rObj." + _referenceInput + Inputs[i] + ";");
                    }
                }

                //Annars kopiera från default fil
                else
                {
                    newContent.Add(line);
                }
            }

            File.WriteAllLines(TargetFileName, newContent);
        }
        private static void CreateModelDll()
        {
            string solutionDirectory = Path.GetDirectoryName(Settings.Default[Solution].ToString());

            string msBuildCommand = $@"""{Settings.Default[MsBuild]}"" ""{Settings.Default[Solution]}""";
            string renameCommand = $@"ren ""{solutionDirectory}{"\\Debug\\GenerateDLL.dll"}"" {_modelDllName}";
            string mkDirectoryCommand = $@"mkDir ""{Settings.Default[TargetFolder]}{"\\"}{_modelFolderName}""";
            string moveCommand = $@"move ""{solutionDirectory}{"\\Debug\\"}{_modelDllName}"" ""{Settings.Default[TargetFolder]}{"\\"}{_modelFolderName}""";
            Console.WriteLine(mkDirectoryCommand);
            Console.WriteLine(moveCommand);

            Process cmd = new Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                }
            };
            cmd.Start();
            cmd.StandardInput.WriteLine(msBuildCommand);
            cmd.StandardInput.WriteLine(renameCommand);
            cmd.StandardInput.WriteLine(mkDirectoryCommand);
            cmd.StandardInput.WriteLine(moveCommand);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            //cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            Console.WriteLine(cmd.StandardError.ReadToEnd());

            string xmlFileNamePath = $@"{Settings.Default[TargetFolder]}{"\\"}{_modelFolderName}{"\\"}{"modelXML.xml"}";
            WriteXml(xmlFileNamePath);
        }
        private static void WriteXml(string fileName)
        {
            XmlTextWriter xWriter=new XmlTextWriter(fileName, Encoding.UTF8);
            xWriter.WriteStartElement("InSignal");

            xWriter.WriteStartElement("NumInSignals");
            xWriter.WriteString(Inputs.Count.ToString());
            xWriter.WriteEndElement();

            xWriter.WriteStartElement("NumOutSignals");
            xWriter.WriteString(Outputs.Count.ToString());
            xWriter.WriteEndElement();

            for (int i = 0; i < Inputs.Count; i++)
            {
                xWriter.WriteStartElement("InSignal");
                WriteXmlSignal(xWriter,i,Inputs[i]);
                xWriter.WriteEndElement();
            }
           
            for (int i = 0; i < Outputs.Count; i++)
            {
                xWriter.WriteStartElement("OutSignal");
                WriteXmlSignal(xWriter, i,Outputs[i]);
                xWriter.WriteEndElement();
            }
            xWriter.WriteEndElement();


            xWriter.Close();


        }
        private static void WriteXmlSignal(XmlTextWriter xWriter, int i,string name)
        {
            xWriter.WriteStartElement("Name");
            xWriter.WriteString(name);
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("Port");
            xWriter.WriteString(i.ToString());
            xWriter.WriteEndElement();
        }
        private static void ResetIOLists()
        {
            Inputs.Clear();
            Outputs.Clear();
        }
    }
}
