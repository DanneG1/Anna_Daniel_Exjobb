#include "stdafx.h"
#include "C:\Users\Anna Forsberg\MATLAB\Projects\testproject\work\codegen\addition_ert_rtw\addition.h"
#include "C:\Users\Anna Forsberg\MATLAB\Projects\testproject\work\codegen\addition_ert_rtw\addition.cpp"

  additionModelClass rObj;


//extern "C" __declspec(dllexport) !functionType !functionName( !parameters )

extern "C" __declspec(dllexport) void initialize() 
{
	rObj.initialize();
}

extern "C" __declspec(dllexport) void setInputs(int port,double value) 
{
	switch(port){
case 0:
rObj.rtU.In1 = value;
break;
case 1:
rObj.rtU.In2 = value;
break;
	}
}

extern "C" __declspec(dllexport) double getOutputs(int port) 
{
	switch(port){
case 0:
 return rObj.rtY.Out1 ;
	default:
		return -1;
	}
}

extern "C" __declspec(dllexport) double getInputs(int port) 
{
	switch(port){
case 0:
 return rObj.rtU.In1 ;
case 1:
 return rObj.rtU.In2 ;
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
