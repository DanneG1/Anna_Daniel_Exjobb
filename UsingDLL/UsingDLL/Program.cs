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
        //hej
        private const string Path = @"C:\Windows\SysWOW64\newDLLfileV2.dll";
        //private const string Path = @"C:\Users\Danne\Documents\simulinkmodels\GenerateDLL.dll";
        //private const string Path = @"C:\Users\Danne\source\repos\Anna_Daniel_Exjobb\GenerateDLL\Debug\GenerateDLL.dll";
        //private const string Path = @"C:\Users\Danne\source\repos\Anna_Daniel_Exjobb\GenerateDLL\x64\Debug\GenerateDLL.dll";
        //private const string Path = @"C:\Users\Danne\Documents\simulinkmodels\Annas\GenerateDLL.dll";
        //private const string Path = @"../../dll/GenerateDLL.dll";
        private const string modelName = "newDLLfileV2.dll";
        private static string directoryPath = @"C:\Windows\SysWOW64\";

        public Program (string path)
        {
            directoryPath = path;
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

        static void Main(string[] args)
        {
            initialize();
            System.Console.WriteLine(Directory.GetCurrentDirectory());
            SetDllDirectory(directoryPath);
            LoadLibrary(directoryPath);



            setInputs(0, 1.0);
            setInputs(1, 1.0);
            setInputs(2, 1.0);
            step();
            double[] result = { getOutputs(0), getOutputs(1), getOutputs(2) };
            foreach(var value in result)
            {
                System.Console.WriteLine(value);
            }
            

            System.Console.ReadKey();
            terminate();
        }
    }
}
