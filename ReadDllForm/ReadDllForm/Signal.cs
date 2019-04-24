using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDllForm
{
    public class Signal
    {
        public int portNumber;
        public string portName;

        public Signal(int port,string Name)
        {
            portNumber = port;
            portName = Name;
        }

        public void PrintSignal()
        {
            Console.WriteLine("Name ="+portName);
            Console.WriteLine("Port= "+portNumber);
        }
        public string getSignalAsString()
        {
            return portName+"\t" + portNumber + Environment.NewLine;
        }

    }
}
