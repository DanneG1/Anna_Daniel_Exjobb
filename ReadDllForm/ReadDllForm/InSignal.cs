using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ReadDllForm
{
    public class InSignal:ISignal
    {
        private IntPtr pDll;
        private int portNumber;
        private string portName;
        

        #region dllDelegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void setInputs(int port, double value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate double getInputs(int port);
        #endregion

        public InSignal(int port,string Name, string path)
        {
            portNumber = port;
            portName = Name;
            pDll = NativeMethods.LoadLibrary(path);

        }

       

        #region DllFunctions
        public void SetSignal(double value)
        {
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "setInputs");
            setInputs Setinputs =
                (setInputs)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(setInputs));

            Setinputs(portNumber, value);
        }
        public double GetSignal()
        {
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "getInputs");
            getInputs GetInputs =
                (getInputs)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(getInputs));
            return GetInputs(portNumber);
        }
        #endregion

        public void PrintSignal()
        {
            Console.WriteLine("Name =" + portName);
            Console.WriteLine("Port= " + portNumber);
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
