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
        private const string ModelDll = @"model.dll";
        public int portNumber;
        public string portName;
        public string path;
        private IntPtr pDll;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void setInputs(int port, double value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate double getInputs(int port);

        public InSignal(int port,string Name, string path)
        {
            this.path = path;
            portNumber = port;
            portName = Name;

            pDll = NativeMethods.LoadLibrary(path);

           

            //SetDllDirectory(path);
            //LoadLibrary(path);
        }

        public void PrintSignal()
        {
            Console.WriteLine("Name ="+portName);
            Console.WriteLine("Port= "+portNumber);
        }

        #region DllFunctions
       /* [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetDllDirectory(string path);

        [DllImport("kernel32", SetLastError = true)]
        static extern IntPtr LoadLibrary(string path);

        [DllImport
            (ModelDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void setInputs(int port, double value);

        [DllImport
            (ModelDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern double getInputs(int port);*/
        #endregion

        public void SetSignal(double value)
        {
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "setInputs");
            setInputs Setinputs =
                (setInputs)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(setInputs));

            Setinputs(portNumber,value);
            
        }

        public double GetSignal()
        {
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "getInputs");
            getInputs GetInputs =
                (getInputs)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(getInputs));

            
            return GetInputs(portNumber);
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
