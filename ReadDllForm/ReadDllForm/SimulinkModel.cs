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
        private string directoryPath;
        private string path;
        public string name;
        private IntPtr pDll;
        private int numberOfInputs;
        private int numberOfOutputs;

        private List<ISignal> inSignals = new List<ISignal>();
        private List<ISignal> outSignals = new List<ISignal>();

        #region Dlldelegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void initialize();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void step();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void terminate();
        #endregion

        #region Getters and setters
        public List<ISignal> GetInSignals()
        {
            return inSignals;
        }
        public List<ISignal> GetOutSignals()
        {
            return outSignals;
        }


        #endregion

        public SimulinkModel(string path)
        {
            this.path = path;
            directoryPath = Path.GetDirectoryName(path);
            pDll = NativeMethods.LoadLibrary(path);

            initialze();
            ReadXML();
            Step();
        }       

        #region dllFunctions
        private void initialze()
        {
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "initialize");
            initialize Initialize =
                (initialize)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(initialize));
            Initialize();

        }
        public void Step()
        {
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "step");
            step Step =
                (step)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(step));
            Step();
        }
        private void Terminate()
        {
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "terminate");
            terminate Terminate =
                (terminate)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(terminate));
            Terminate();
        }
        #endregion

        private void ReadXML()
        {
            XmlTextReader reader = new XmlTextReader(directoryPath + "\\modelXML.xml");
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
                        InSignal inSignal = new InSignal(port, Name, path);
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
                        OutSignal outSignal = new OutSignal(port, Name, path);
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
           Terminate();
        }
    }
}
