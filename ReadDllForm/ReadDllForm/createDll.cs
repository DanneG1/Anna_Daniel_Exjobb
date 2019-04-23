using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ReadDllForm.Properties;

namespace ReadDllForm
{
    class createDll
    {
        private const string Solution = "Solution";
        private const string MsBuild = "MsBuild";
        private const string TargetFolder = "TargetFolder";
        private static readonly string ExampleFilePath = @"..\..\files\exampleCppDLL.txt";
        private static readonly string SolutionFileName = Settings.Default["Solution"].ToString();
        private static readonly string SolutionDirectory = Path.GetDirectoryName(SolutionFileName);
        private static readonly string TargetFileName = SolutionDirectory + "\\GenerateDLL\\GenerateDLL.cpp";

        private static string hPath;
        private static string cppPath;
        private static string referenceInput;
        private static string referenceOutput;
        private static string modelName;
        private static string newModelName;

        public static List<String> inputs = new List<String>();
        public static List<String> outputs = new List<String>();

        public void CreateFile(string h, string cpp, string modelName)
        {
            hPath = h;
            cppPath = cpp;
            newModelName = modelName;
            
            FindIO();
            FormatIO();
            GenerateCppFile();
            CreateModelDll();
            ResetIOLists();
        }

        private static IEnumerable<String> ReadFile()
        {
            IEnumerable<String> lines = File.ReadLines(hPath);
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
                        inputs.Add(line);

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
                        outputs.Add(line);
                }
                if (line.Contains("Constructor") || foundConstructor)
                {
                    if (!foundConstructor)
                        foundConstructor = true;
                    else
                    {
                        string[] splitLine = line.Split('(');
                        modelName = splitLine[0];
                        foundConstructor = false;
                    }
                }
                if (inputMatch.Success)
                {
                    string[] splitLine = line.Split(' ');
                    referenceInput = splitLine[3];
                    referenceInput = referenceInput.Replace(';', '.');
                    System.Console.WriteLine(referenceInput);
                }
                if (outputMatch.Success)
                {
                    string[] splitLine = line.Split(' ');
                    referenceOutput = splitLine[3];
                    referenceOutput = referenceOutput.Replace(';', '.');

                    System.Console.WriteLine(referenceOutput);
                }
            }

        }
        private static void FormatIO()
        {
            List<String> newInputs = new List<string>();
            List<String> newOutputs = new List<string>();

            foreach (var input in inputs)
            {
                string[] inputArr = input.Split(' ');
                inputArr[3] = inputArr[3].Replace(';', ' ');
                newInputs.Add(inputArr[3]);

            }
            foreach (var output in outputs)
            {
                string[] outputArr = output.Split(' ');
                outputArr[3] = outputArr[3].Replace(';', ' ');
                newOutputs.Add(outputArr[3]);
            }
            inputs = newInputs;
            outputs = newOutputs;
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
                    newContent.Add("#include \"" + hPath + "\"");
                }
                else if (line.Contains(" !.cpp "))
                {
                    newContent.Add("#include \"" + cppPath + "\"");
                }

                //Skapa modellen
                else if (line.Contains("!modelName"))
                {
                    newContent.Add(modelName + " rObj;");
                }

                //Skapa switch case för setInputs
                else if (line.Contains("!setInputCase"))
                {
                    for (int i = 0; i < inputs.Count(); ++i)
                    {
                        newContent.Add("case " + i + ":");
                        newContent.Add("rObj." + referenceInput + inputs[i] + "= value;");
                        newContent.Add("break;");
                    }
                }

                //Skapa switch case för getOutputs
                else if (line.Contains("!getOutputCase"))
                {
                    for (int i = 0; i < outputs.Count(); ++i)
                    {
                        newContent.Add("case " + i + ":");
                        newContent.Add(" return rObj." + referenceOutput + outputs[i] + ";");
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
            string msbuild = "\"" + Settings.Default[MsBuild] + "\"";
            string solution = "\"" + Settings.Default[Solution] + "\"";
            string solutionDir = Path.GetDirectoryName(Settings.Default[Solution].ToString());
            string targetDir =  Settings.Default[TargetFolder].ToString();
            string targetFile = "\"" + solutionDir + "\\Debug\\GenerateDLL.dll" + "\"";

            //string newFileName = newModelName + ".dll";
            string modelName = "model.dll";
            string renameCommand = "ren " + targetFile + " " + modelName;
            string mkDirectoryCommand = "mkDir " +"\""+ targetDir + "\\" + newModelName+"\"";
            string moveCommand = "move " + "\"" + solutionDir + "\\Debug\\" + modelName + "\"" + " " + "\"" + targetDir + "\\" + newModelName + "\""; ;

            //Console.WriteLine(renameCommand + moveCommand);
            Console.WriteLine(mkDirectoryCommand);
            Console.WriteLine(moveCommand);

            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.RedirectStandardError = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(msbuild + " " + solution);
            cmd.StandardInput.WriteLine(renameCommand);
            cmd.StandardInput.WriteLine(mkDirectoryCommand);
            cmd.StandardInput.WriteLine(moveCommand);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            //cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            Console.WriteLine(cmd.StandardError.ReadToEnd());

        }
        private static void ResetIOLists()
        {
            inputs.Clear();
            outputs.Clear();
        }
    }
}
