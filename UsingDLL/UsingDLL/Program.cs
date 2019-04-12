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
        private const string Path = @"../../dll/GenerateDLL.dll";
        [DllImport
            (Path, CallingConvention = CallingConvention.Cdecl)]
        public static extern void initialize();

        [DllImport
            (Path, CallingConvention = CallingConvention.Cdecl)]
        public static extern void step();

        [DllImport
            (Path, CallingConvention = CallingConvention.Cdecl)]
        public static extern double getOutputs(int port);

        [DllImport
            (Path, CallingConvention = CallingConvention.Cdecl)]
        public static extern void setInputs(int port,double value);

        [DllImport
            (Path, CallingConvention = CallingConvention.Cdecl)]
        public static extern void terminate();

        static void Main(string[] args)
        {
            initialize();
            System.Console.WriteLine(Directory.GetCurrentDirectory());
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
