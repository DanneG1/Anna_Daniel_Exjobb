#include "stdafx.h"
#include "C:\Users\Danne\Documents\MATLAB\input_times_5_ert_rtw\input_times_5.h"
#include "C:\Users\Danne\Documents\MATLAB\input_times_5_ert_rtw\input_times_5.cpp"

  input_times_5ModelClass rObj;


//extern "C" __declspec(dllexport) !functionType !functionName( !parameters )

extern "C" __declspec(dllexport) void initialize() 
{
	rObj.initialize();
}

extern "C" __declspec(dllexport) void setInputs(int port,double value) 
{
	switch(port){
case 0:
rObj.input_times_5_U.Input1 = value;
break;
	}
}

extern "C" __declspec(dllexport) double getOutputs(int port) 
{
	switch(port){
case 0:
 return rObj.input_times_5_Y.Out1 ;
	default:
		return -1;
	}
}

extern "C" __declspec(dllexport) double getInputs(int port) 
{
	switch(port){
case 0:
 return rObj.input_times_5_U.Input1 ;
	default:
		return -1;
	}
}

extern "C" __declspec(dllexport) void step()
{
	rObj.step();
}

extern "C" __declspec(dllexport) void terminate()
{
	rObj.terminate();
}
