using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using HiQ.HiMacs.WCF.Client;
using System.Diagnostics;
using System.Threading;


namespace ReadDllForm
{

    class SimulinkModel
    {
        private readonly IntPtr _pDll;
        private readonly string _directoryPath;
        private readonly string _path;
        private readonly string _name;
        private HiCoreClient _hiCore;
        private readonly string _worstTime;
        private Boolean running = false;
        private int sleep;
        public Thread threadRun;

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

        public string GetName()
        {
            return _name;
        }
        public string getWorstTime()
        {
            return _worstTime;
        }
        public void setRunning(Boolean state)
        {
            running = state;
        }
        public Boolean getRunning()
        {
            return running;
        }
        public void setSleep(int sleepy)
        {
            sleep = sleepy;
        }
        public double getSleep()
        {
            return sleep;
        }

        #endregion

        public SimulinkModel(string path,HiCoreClient hicore)
        {
            _hiCore = hicore;
            _pDll = NativeMethods.LoadLibrary(path);
            _path = path;
            _directoryPath = Path.GetDirectoryName(path);
            _name = new DirectoryInfo(_directoryPath).Name;

            Initialze();
            ReadXml();
            _worstTime = findWorstTime();
        }

        #region dllFunctions
        private void Initialze()
        {
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(_pDll, "initialize");
            initialize Initialize =
                (initialize)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(initialize));
            Initialize();

        }
        public void Step()
        {
            foreach (var inSignal in inSignals)
            {
                inSignal.update();
            }
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(_pDll, "step");
            step Step =
                (step)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(step));
            Step();
            foreach (var outSignal in outSignals)
            {
                outSignal.update();
            }
        }
        private void Terminate()
        {
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(_pDll, "terminate");
            terminate Terminate =
                (terminate)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(terminate));
            Terminate();
        }
        #endregion
        #region modelFunctions
        private void ReadXml()
        {
            XmlTextReader reader = new XmlTextReader(_directoryPath + "\\modelXML.xml");
            reader.Read();
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (reader.Name == "InSignal")
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
                        InSignal inSignal = new InSignal(port, Name, _path,_hiCore);
                        //inSignal.SetSignal(5);
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
                        OutSignal outSignal = new OutSignal(port, Name, _path,_hiCore);
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
        public string findWorstTime()
        {
            List<double> timer = new List<double>();
            for (int i = 0; i < 11; ++i)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Step();
                sw.Stop();
                Console.WriteLine(sw.Elapsed);
                //Första tiden när första modellen laddas in är orimligt hög, sparar därför endast efter i>0
                if (i > 0)
                {
                    timer.Add(sw.Elapsed.TotalMilliseconds);
                }
            }
            return timer.Max().ToString();
        }
        public void Run()
        {
            //skapa någon slags funktion som kör samtidigt som hiCore är igång på samma freq
            threadRun = new Thread(RunFunc)
            {
                IsBackground = true
            };
            try
            {
                threadRun.Start();
            }
            catch(Exception e){}
            
        }

        public void StopRun()
        {
            threadRun.Abort();
        }


        public void RunFunc()
        {
            while (running)
            {
                Step();
                Thread.Sleep(sleep);
            }
        }



        #endregion
        ~SimulinkModel()
        {
           Terminate();
        }
    }
}
