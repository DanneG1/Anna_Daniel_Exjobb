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

    public class SimulinkModel
    {
        private readonly IntPtr _pDll;
        private readonly string _directoryPath;
        private readonly string _path;
        private readonly string _name;
        private readonly HiCoreClient _hiCore;
        private Boolean _running;
        private double _sleep;
        public Thread ThreadRun;

        private List<ISignal> _inSignals = new List<ISignal>();
        private List<ISignal> _outSignals = new List<ISignal>();
        public List<double> TimeSample = new List<double>();

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
            return _inSignals;
        }
        public List<ISignal> GetOutSignals()
        {
            return _outSignals;
        }

        public List<ISignal> GetAllSignals()
        {
            List<ISignal> allSignals = new List<ISignal>();
            allSignals.AddRange(_inSignals);
            allSignals.AddRange(_outSignals);
            return allSignals;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetRunning(Boolean state)
        {
            _running = state;
        }
        public Boolean GetRunning()
        {
            return _running;
        }
        public void SetSleep(double sleepy)
        {
            _sleep = sleepy;
        }

        public string GetPath()
        {
            return _path;
        }

        #endregion

        public SimulinkModel( string path, HiCoreClient hicore,List<ISignal>inSignals,List<ISignal>outSignals)
        {
           
            _hiCore = hicore;
            _pDll = DllMethods.LoadLibrary(path);
            _path = path;
            _directoryPath = Path.GetDirectoryName(path);
            _name = new DirectoryInfo(_directoryPath).Name;

            Initialze();
            _inSignals = inSignals;
            _outSignals = outSignals;
        }
        public SimulinkModel(string path,HiCoreClient hicore, XmlHelper xmlHelper)
        {
           
            _hiCore = hicore;
            _pDll = DllMethods.LoadLibrary(path);
            _path = path;
            _directoryPath = Path.GetDirectoryName(path);
            _name = new DirectoryInfo(_directoryPath).Name;

            Initialze();
            ReadXml();
        }
       

        #region dllFunctions
        private void Initialze()
        {
            IntPtr pAddressOfFunctionToCall = DllMethods.GetProcAddress(_pDll, "initialize");
            initialize Initialize =
                (initialize)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(initialize));
            Initialize();

        }
        public void Step()
        {
            foreach (var inSignal in _inSignals)
            {
                inSignal.Update();
            }
            IntPtr pAddressOfFunctionToCall = DllMethods.GetProcAddress(_pDll, "step");
            step Step =
                (step)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(step));
            Step();
            foreach (var outSignal in _outSignals)
            {
                outSignal.Update();
            }
        }
        private void Terminate()
        {
            IntPtr pAddressOfFunctionToCall = DllMethods.GetProcAddress(_pDll, "terminate");
            terminate Terminate =
                (terminate)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(terminate));
            Terminate();
        }
        #endregion
        #region modelFunctions
        private void ReadXml()
        {
            XmlHelper _xmlHelper = new XmlHelper();
            List<ISignal>signals =_xmlHelper.ReadXmlSimulinkModel(_directoryPath,_path,_hiCore);
            _inSignals.AddRange(signals.OfType<InSignal>().ToList());
            _outSignals.AddRange(signals.OfType<OutSignal>().ToList());
        }

        public void Run()
        {
            //skapa någon slags funktion som kör samtidigt som hiCore är igång på samma freq
            ThreadRun = new Thread(RunFunc)
            {
                IsBackground = true
            };
            try
            {
                ThreadRun.Start();
            }
            catch(Exception e){}
            
        }

        public void StopRun()
        {
            ThreadRun.Abort();

            //timer
            TimeSample.Clear();
        }


        public void RunFunc()
        {
            while (_running)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Step();
                sw.Stop();
                TimeSample.Add(sw.Elapsed.TotalMilliseconds);
                Thread.Sleep(Convert.ToInt32(1000/_sleep));
            }
        }



        #endregion
        ~SimulinkModel()
        {
           Terminate();
        }
    }
}
