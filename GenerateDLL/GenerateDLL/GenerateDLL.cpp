#include "stdafx.h"
#include "C:\Users\Danne\Documents\MATLAB\trippleinput_different_datatypes_ert_rtw\trippleinput_different_datatypes.h"
#include "C:\Users\Danne\Documents\MATLAB\trippleinput_different_datatypes_ert_rtw\trippleinput_different_datatypes.cpp"

  trippleinput_different_datatypesModelClass rObj;


//extern "C" __declspec(dllexport) !functionType !functionName( !parameters )

extern "C" __declspec(dllexport) void initialize() 
{
	rObj.initialize();
}

extern "C" __declspec(dllexport) void setInputs(int port,double value) 
{
	switch(port){
case 0:
rObj.trippleinput_different_dataty_U.Input1_signal = value;
break;
case 1:
rObj.trippleinput_different_dataty_U.input2_signal = value;
break;
case 2:
rObj.trippleinput_different_dataty_U.Input3_signal = value;
break;
	}
}

extern "C" __declspec(dllexport) double getOutputs(int port) 
{
	switch(port){
case 0:
 return rObj.trippleinput_different_dataty_Y.Addition_output ;
case 1:
 return rObj.trippleinput_different_dataty_Y.Input2_copyOutport ;
case 2:
 return rObj.trippleinput_different_dataty_Y.Multiply_Output ;
	default:
		return -1;
	}
}

extern "C" __declspec(dllexport) double getInputs(int port) 
{
	switch(port){
case 0:
 return rObj.trippleinput_different_dataty_U.Input1_signal ;
case 1:
 return rObj.trippleinput_different_dataty_U.input2_signal ;
case 2:
 return rObj.trippleinput_different_dataty_U.Input3_signal ;
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
