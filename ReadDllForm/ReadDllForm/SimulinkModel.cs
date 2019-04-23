using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReadDllForm
{
    class SimulinkModel
    {
        private const string ModelDll = @"ModelDll.dll";
        private string DirectoryPath;

        public SimulinkModel(string path)
        {
            DirectoryPath = path;
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetDllDirectory(string path);
        [DllImport("kernel32", SetLastError = true)]
        static extern IntPtr LoadLibrary(string path);

        [DllImport
            (ModelDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void initialize();

        [DllImport
            (ModelDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void step();

        [DllImport
            (ModelDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern double getOutputs(int port);

        [DllImport
            (ModelDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void setInputs(int port, double value);

        [DllImport
            (ModelDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void terminate();

        
    }
}
