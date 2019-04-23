using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;

namespace UsingDLL
{
    class Program
    {
        private const string modelName = "Model.dll";
        private static string directoryPath;

        public Program (string path)
        {
            directoryPath = path;
            SetDllDirectory(directoryPath);
            LoadLibrary(directoryPath);
           
        }


        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetDllDirectory(string path);
        [DllImport("kernel32", SetLastError = true)]
        static extern IntPtr LoadLibrary(string path);

        [DllImport
            (modelName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void initialize();

        [DllImport
            (modelName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void step();

        [DllImport
            (modelName, CallingConvention = CallingConvention.Cdecl)]
        public static extern double getOutputs(int port);

        [DllImport
            (modelName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void setInputs(int port,double value);

        [DllImport
            (modelName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void terminate();

       
    }
}
