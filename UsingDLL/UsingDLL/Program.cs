using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace UsingDLL
{
    class Program
    {
        [DllImport
            (@"C:\Users\Danne\Source\Repos\Anna_Daniel_Exjobb\GenerateDLL\Debug\GenerateDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void initialize();

        [DllImport
            (@"C:\Users\Danne\Source\Repos\Anna_Daniel_Exjobb\GenerateDLL\Debug\GenerateDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void step();

        [DllImport
            (@"C:\Users\Danne\Source\Repos\Anna_Daniel_Exjobb\GenerateDLL\Debug\GenerateDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double getInputs(int port);

        [DllImport
            (@"C:\Users\Danne\Source\Repos\Anna_Daniel_Exjobb\GenerateDLL\Debug\GenerateDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void setInputs(int port,double value);

        [DllImport
            (@"C:\Users\Danne\Source\Repos\Anna_Daniel_Exjobb\GenerateDLL\Debug\GenerateDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void terminate();

        static void Main(string[] args)
        {
            initialize();
            setInputs(0, 1.0);
            setInputs(1, 1.0);
            setInputs(2, 1.0);
            step();
            double[] result = { getInputs(0), getInputs(1), getInputs(2) };
            foreach(var value in result)
            {
                System.Console.WriteLine(value);
            }
            terminate();
        }
    }
}
