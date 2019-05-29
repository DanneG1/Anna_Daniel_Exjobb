using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDllForm
{
    public interface ISignal
    {
        void SetSignal(double value);
        double GetSignal();
        void SetChannelName(string channelName);
        string GetChannelName();
        int GetPortNumber();
        string GetSignalName();
        void Update();

    }
}
 