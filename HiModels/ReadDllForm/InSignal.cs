﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using HiQ.HiMacs.WCF.Client;
namespace ReadDllForm
{
    public class InSignal:ISignal
    {
        private readonly IntPtr _pDll;
        private readonly int _portNumber;
        private readonly string _portName;
        private string _channelName = "-";
        private readonly HiCoreClient _hiCore;

        #region dllDelegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void SetInputs(int port, double value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate double GetInputs(int port);
        #endregion

        public InSignal(int port,string name, string path,HiCoreClient hiCore)
        {
            _hiCore = hiCore;
            _portNumber = port;
            _portName = name;
            _pDll = DllMethods.LoadLibrary(path);

        }
        public InSignal(int port, string name, string path, HiCoreClient hiCore,string channelName)
        {
            _hiCore = hiCore;
            _portNumber = port;
            _portName = name;
            _pDll = DllMethods.LoadLibrary(path);
            _channelName = channelName;

        }

        #region DllFunctions
        public void SetSignal(double value)
        {
            IntPtr pAddressOfFunctionToCall = DllMethods.GetProcAddress(_pDll, "setInputs");
            SetInputs setinputs =
                (SetInputs)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(SetInputs));

            setinputs(_portNumber, value);
        }
        public double GetSignal()
        {
            IntPtr pAddressOfFunctionToCall = DllMethods.GetProcAddress(_pDll, "getInputs");
            GetInputs getInputs =
                (GetInputs)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(GetInputs));
            return getInputs(_portNumber);
        }
        #endregion

        public void SetChannelName(string channelName)
        {
            _channelName = channelName;
        }
        public string GetChannelName()
        {
            return _channelName;
        }
        public int GetPortNumber()
        {
            return _portNumber;
        }
        public string GetSignalName()
        {
            return _portName;
        }
        public void Update()
        {
            if (_channelName != "-")
            {
                SetSignal(_hiCore.GetValue("", _channelName));
            }
        }

       
    }
}
