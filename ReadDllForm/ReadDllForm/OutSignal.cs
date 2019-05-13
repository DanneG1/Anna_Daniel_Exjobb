﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using HiQ.HiMacs.WCF.Client;

namespace ReadDllForm
{
    class OutSignal:ISignal
    {
        private IntPtr _pDll;
        private readonly int _portNumber;
        private readonly string _portName;
        private string _channelName="-";
        private readonly HiCoreClient _hiCore;

        #region dllDelegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate double getOutputs(int port);
        #endregion

        public OutSignal(int port, string name, string path,HiCoreClient hiCore)
        {
            _hiCore = hiCore;
            _portNumber = port;
            _portName = name;
            _pDll = DllMethods.LoadLibrary(path);
        }

        public OutSignal(int port, string name, string path, HiCoreClient hiCore, string channelName)
        {
            _hiCore = hiCore;
            _portNumber = port;
            _portName = name;
            _pDll = DllMethods.LoadLibrary(path);
            _channelName = channelName;

        }

        #region DllFunctions
        public double GetSignal()
        {
            IntPtr pAddressOfFunctionToCall = DllMethods.GetProcAddress(_pDll, "getOutputs");
            getOutputs GetOutputs =
                (getOutputs)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(getOutputs));

            return GetOutputs(_portNumber);
        }

        public void SetSignal(double value)
        {
            //do nothing
        }
        #endregion

      

        public string GetSignalAsString()
        {
            return _portName + "\t" + GetSignal() + Environment.NewLine;
        }

        public string GetSignalName()
        {
            return _portName;
        }

        public void SetChannelName(string channelName)
        {
            _channelName = channelName;
        }

        public int GetPortNumber()
        {
            return _portNumber;
        }

        public void update()
        {
            if (_channelName != "-")
            {
                _hiCore.SetValue("", _channelName, GetSignal());
            }
        }

        public string GetChannelName()
        {
            return _channelName;
        }
    }
}
