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
        private IntPtr pDll;
        public int portNumber;
        public string portName;

        #region dllDelegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate double getOutputs(int port);
        #endregion




        public OutSignal(int port, string Name, string path)
        {
            portNumber = port;
            portName = Name;
            pDll = NativeMethods.LoadLibrary(path);
        }

        #region DllFunctions
        public double GetSignal()
        {
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "getOutputs");
            getOutputs GetOutputs =
                (getOutputs)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(getOutputs));

            return GetOutputs(portNumber);
        }

        public void SetSignal(double value)
        {
            //do nothing
        }
        #endregion



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
