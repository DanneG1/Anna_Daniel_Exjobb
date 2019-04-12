using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReadDllForm
{
    class createDll
    {
        public static string hPath;
        static string exampleFilePath = @"..\..\files\exampleCppDLL.txt";
        private static string cppPath;

        public static List<String> inputs = new List<String>();
        public static List<String> outputs = new List<String>();

        public static string referenceInput = "";
        public static string referenceOutput = "";
        public static string modelName = "";


        public createDll(string h, string cpp)
        {
            hPath = h;
            cppPath = cpp;
        }

        public void createFile()
        {
            IEnumerable<String> text = ReadFile();
            FindIO(text);
            formatIO();
            GenerateCppFile();
        }
       
           
            public static IEnumerable<String> ReadFile()
            {
                System.Collections.Generic.IEnumerable<String> lines = File.ReadLines(hPath);
                return lines;
            }

            public static void FindIO(IEnumerable<String> lines)
            {
                Boolean foundInputs = false;
                Boolean foundOutputs = false;
                Boolean foundConstructor = false;
                Regex inputRegex = new Regex("(.*)ExtU(.*)");
                Regex outputRegex = new Regex("(.*)ExtY(.*)");

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
            public static void GenerateCppFile()
            {
               
                

                System.Collections.Generic.IEnumerable<String> lines = File.ReadLines(exampleFilePath);
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

                File.WriteAllLines("newDLLfileV2.cpp", newContent);

            }
            public static void formatIO()
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

     
        }
}
