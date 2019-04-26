using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReadDllForm
{
    class OutSignal:ISignal
    {
        private const string ModelDll = @"model.dll";
        public int portNumber;
        public string portName;
        public string path;
        private IntPtr pDll;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate double getOutputs(int port);

        

        public OutSignal(int port, string Name, string path)
        {
            this.path = path;
            portNumber = port;
            portName = Name;
            pDll = NativeMethods.LoadLibrary(path);
            //SetDllDirectory(path);
            //LoadLibrary(path);
        }

        #region DllFunctions
       /* [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetDllDirectory(string path);

        [DllImport("kernel32", SetLastError = true)]
        static extern IntPtr LoadLibrary(string path);

        [DllImport
            (ModelDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern double getOutputs(int port);*/
        #endregion



        public void SetSignal(double value)
        {
            //do nothing
        }

        public double GetSignal()
        {
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "getOutputs");
            getOutputs GetOutputs =
                (getOutputs)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(getOutputs));

            

            return GetOutputs(portNumber);
        }

        public string GetSignalAsString()
        {
            return portName + "\t" + GetSignal() + Environment.NewLine;
        }

        public string GetSignalName()
        {
            return portName;
        }
    }
}
