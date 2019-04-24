using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReadDllForm
{
    class SimulinkModel
    {
        private const string ModelDll = @"model.dll";
        private string DirectoryPath;
        private int numberOfInputs;
        private int numberOfOutputs;
        private List<ISignal> inSignals = new List<ISignal>();
        private List<ISignal> outSignals = new List<ISignal>();
        private string path;

        public List<ISignal> GetSignals()
        {
            return inSignals;
        }

        public SimulinkModel(string path)
        {
            this.path = path;
            DirectoryPath = Path.GetDirectoryName(path);
            SetDllDirectory(path);
            LoadLibrary(path);
            initialize();

            ReadXML();
            step();
        }

        #region DllFunctions
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetDllDirectory(string path);
        [DllImport("kernel32", SetLastError = true)]
        static extern IntPtr LoadLibrary(string path);

        [DllImport
            (ModelDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void initialize();

        [DllImport
            (ModelDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void step();

        [DllImport
            (ModelDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void terminate();
        #endregion




        private void ReadXML()
        {
            XmlTextReader reader = new XmlTextReader(DirectoryPath+"\\modelXML.xml");
            reader.Read();
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (reader.Name == "NumInSignals")
                    {
                        numberOfInputs = Convert.ToInt32(reader.ReadString());
                    }
                    else if (reader.Name == "NumOutSignals")
                    {
                        numberOfOutputs = Convert.ToInt32(reader.ReadString());
                    }
                    else if (reader.Name == "InSignal")
                    {
                        reader.Read();
                        string Name = "";
                        if (reader.Name == "Name")
                        {
                            Name = reader.ReadString();
                        }

                        reader.Read();  
                        int port = -1;
                        if (reader.Name == "Port")
                        {
                            port = Convert.ToInt32(reader.ReadString());
                        }
                        InSignal inSignal = new InSignal(port, Name,path);
                        inSignal.SetSignal(5);
                        inSignals.Add(inSignal);
                        

                    }
                    else if (reader.Name == "OutSignal")
                    {
                        string Name = "";
                        int port = 0;
                        reader.Read();
                        if (reader.Name == "Name")
                        {
                            Name = reader.ReadString();
                        }
                        reader.Read();
                        if (reader.Name == "Port")
                        {
                            port = Convert.ToInt32(reader.ReadString());
                        }
                        OutSignal outSignal=new OutSignal(port,Name,path);
                        outSignals.Add(outSignal);
                    }
                }
            }           
        }

        public string GetSignalsAsString()
        {
            string signals="";
            signals += "In signals: " + Environment.NewLine;
            foreach (var signal in inSignals)
            {
                signals+= signal.GetSignalAsString();
                signals += "\n";
            }
            signals += Environment.NewLine+ "Out signals: " + Environment.NewLine;
            foreach (var signal in outSignals)
            {
                signals += signal.GetSignalAsString();
            }
            return signals;
        }
        

        ~SimulinkModel()
        {
            terminate();
        }
    }
}
