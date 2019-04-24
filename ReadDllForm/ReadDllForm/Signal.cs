using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ReadDllForm
{
    public class Signal
    {
        private const string ModelDll = @"model.dll";
        public int portNumber;
        public string portName;
        public string path;

        public Signal(int port,string Name, string path)
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

        public string getSignalAsString()
        {
            return portName+"\t" + getOutput() + Environment.NewLine;
        }


        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetDllDirectory(string path);
        [DllImport("kernel32", SetLastError = true)]
        static extern IntPtr LoadLibrary(string path);

        [DllImport
           (ModelDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern double getOutputs(int port);

        [DllImport
            (ModelDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void setInputs(int port, double value);

        public void setInput(double value)
        {
            setInputs(portNumber, value);
        }
        public double getOutput()
        {
            return getOutputs(portNumber);
        }
    }
}
