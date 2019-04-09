using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


/*
 *Fungerar skapligt. Problem med return funktionen. Eftersom koden blir i C kan vi inte skicka tillbaka en vanlig array av double
 * Titta på alternativa lösningar och bättre lösningar överlag då detta känns som en relativt dålig lösning på vårt problem.
 *
 */

namespace Read_Header_generate_CppCode
{
    class Program
    {

        public static string textFile = @"C:\Users\Danne\Documents\MATLAB\addition_times_5_v2_ert_shrlib_rtw\addition_times_5_v2.h";
        public static string textFile2 = @"C:\Users\Danne\Documents\MATLAB\trippleinput_different_datatypes_ert_rtw\trippleinput_different_datatypes.h";

        public static List<String> inputs = new List<String>();
        public static List<String> outputs = new List<String>();

        public static string referenceInput = "";
        public static string referenceOutput = "";

        public static IEnumerable<String> ReadFile()
        {
            System.Collections.Generic.IEnumerable<String> lines = File.ReadLines(textFile2);
            /* foreach(var line in lines)
             {
                 System.Console.WriteLine(line);
             }*/
            return lines;
        }

        public static void FindIO(IEnumerable<String> lines)
        {
            //List<String> inputs=new List<String>();
            //List<String> outputs = new List<String>();
            Boolean foundInputs = false;
            Boolean foundOutputs = false;
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
        public static void PrintIO()
        {
            System.Console.WriteLine("*****INPORTS*****");
            foreach (var line in inputs)
            {
                System.Console.WriteLine(line);
            }
            System.Console.WriteLine("*****OUTPORTS*****");
            foreach (var line in outputs)
            {
                System.Console.WriteLine(line);
            }
        }

        public static void GenerateCppFile()
        {
            string exampleFilePath = @"C:\Users\Danne\Desktop\Universitet\year3\Exjobb\exampleCppDLL.txt";
            System.Collections.Generic.IEnumerable<String> lines = File.ReadLines(exampleFilePath);
            List<String> newContent = new List<String>();
            string hPath = textFile2;
            //string cppPath=
            string functionType = "double";
            string functionName = "TestFunction";
            string parameters = "";
            string modelname = "trippleinput_different_datatypesModelClass"; //Fixa så den hittar modellnamnet automatiskt.
            string instanceModel = "trippleinput_different_data_Obj"; //Fixa så den hittar instancen av modellens namn automatiskt.
            String[] inportname = new string[inputs.Count()];

            //Skapa rätt antal parametrar med standard namnen in0, in1 etc.
            int paramCount = inputs.Count();
            for (int i = 0; i < paramCount; ++i)
            {
                if (!(i == paramCount - 1))
                    parameters += "double in" + i + " ,";
                else
                    parameters += "double in" + i;

            }
            for (int i = 0; i < inputs.Count(); ++i)
            {
                //funkar inte som den borde, slarvig för att se om konceptet fungerar
                inportname[i] = inputs[i];
            }

            foreach (var line in lines)
            {
                //Sätt paths till .h och .cpp fil
                if (line.Contains("!.h "))
                {
                    newContent.Add("#include \"" + @"C:\Users\Danne\Documents\MATLAB\trippleinput_different_datatypes_ert_rtw\trippleinput_different_datatypes.h" + "\"");
                }
                else if (line.Contains(" !.cpp "))
                {
                    newContent.Add("#include \"" + @"C:\Users\Danne\Documents\MATLAB\trippleinput_different_datatypes_ert_rtw\trippleinput_different_datatypes.cpp" + "\"");
                }

                //Sätt information till funktionen
                else if (line.Contains("!functionType"))
                {
                    newContent.Add("extern \"C\" __declspec(dllexport) " + functionType + " " + functionName + "(" + parameters + " )");
                }

                //Skapa modellen
                else if (line.Contains("!modelName"))
                {
                    newContent.Add(modelname + " rObj;");
                }

                //Sätt inportsen till parameterna från funktionen
                else if (line.Contains("!setInports"))
                {
                    for (int i = 0; i < paramCount; ++i)
                    {
                        newContent.Add("rObj." + referenceInput + inportname[i] + "= in" + i + ";");
                    }
                }

                //Skapa Array med alla outputs

                //Skapa return
                else if (line.Contains("!return"))
                {
                    string outputFunction = "double outputs[" + outputs.Count() + "] ={ ";
                    for (int i = 0; i < outputs.Count(); ++i)
                    {
                        if (!(i == outputs.Count() - 1))
                            outputFunction += "rObj." + referenceOutput + outputs[i] + ",";
                        else
                            outputFunction += "rObj." + referenceOutput + outputs[i];

                    }
                    outputFunction += "\n}";
                    newContent.Add(outputFunction);
                    newContent.Add("return outputs;");

                    //newContent.Add("double[" + outputs.Count() + "] outputs; ");

                    //newContent.Add("return 1");
                }

                //Annars kopiera från default fil
                else
                {
                    newContent.Add(line);
                }
            }

            File.WriteAllLines("newDLLfile.cpp", newContent);

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

        static void Main(string[] args)
        {
            IEnumerable<String> text = ReadFile();
            FindIO(text);
            formatIO();
            PrintIO();
            GenerateCppFile();
        }
    }
}
