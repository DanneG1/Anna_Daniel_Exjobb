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
        private readonly IntPtr _pDll;
        private readonly int _portNumber;
        private readonly string _portName;       

        #region dllDelegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void setInputs(int port, double value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate double getInputs(int port);
        #endregion

        public InSignal(int port,string Name, string path)
        {
            _portNumber = port;
            _portName = Name;
            _pDll = NativeMethods.LoadLibrary(path);

        } 

        #region DllFunctions
        public void SetSignal(double value)
        {
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(_pDll, "setInputs");
            setInputs Setinputs =
                (setInputs)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(setInputs));

            Setinputs(_portNumber, value);
        }
        public double GetSignal()
        {
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(_pDll, "getInputs");
            getInputs GetInputs =
                (getInputs)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(getInputs));
            return GetInputs(_portNumber);
        }
        #endregion

        public void PrintSignal()
        {
            Console.WriteLine("Name =" + _portName);
            Console.WriteLine("Port= " + _portNumber);
        }
        public string GetSignalAsString()
        {
            return _portName + "\t" + GetSignal() + Environment.NewLine;
        }

        public string GetSignalName()
        {
            return _portName;
        }
    }
}
