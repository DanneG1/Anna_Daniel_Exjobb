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

        public InSignal(int port,string Name, string path)
        {
            this.path = path;
            portNumber = port;
            portName = Name;
            SetDllDirectory(path);
            LoadLibrary(path);
        }

        public void PrintSignal()
        {
            Console.WriteLine("Name ="+portName);
            Console.WriteLine("Port= "+portNumber);
        }

        #region DllFunctions
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetDllDirectory(string path);

        [DllImport("kernel32", SetLastError = true)]
        static extern IntPtr LoadLibrary(string path);

        [DllImport
            (ModelDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void setInputs(int port, double value);

        [DllImport
            (ModelDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern double getInputs(int port);
        #endregion

        public void SetSignal(double value)
        {
            setInputs(portNumber, value);
        }

        public double GetSignal()
        {
            return getInputs(portNumber);
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
