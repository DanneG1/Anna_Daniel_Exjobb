#include "stdafx.h"
#include "C:\Users\Danne\Documents\MATLAB\Examples\simulink_general\sldemo_bounceExample\sldemo_bounce_v2\sldemo_bounceExample\sldemo_bounce_ert_rtw\sldemo_bounce.h"
#include "C:\Users\Danne\Documents\MATLAB\Examples\simulink_general\sldemo_bounceExample\sldemo_bounce_v2\sldemo_bounceExample\sldemo_bounce_ert_rtw\sldemo_bounce.cpp"

  sldemo_bounceModelClass rObj;


//extern "C" __declspec(dllexport) !functionType !functionName( !parameters )

extern "C" __declspec(dllexport) void initialize() 
{
	rObj.initialize();
}

extern "C" __declspec(dllexport) void setInputs(int port,double value) 
{
	switch(port){
	}
}

extern "C" __declspec(dllexport) double getOutputs(int port) 
{
	switch(port){
case 0:
 return rObj.sldemo_bounce_Y.position_out ;
case 1:
 return rObj.sldemo_bounce_Y.velocity_out ;
	default:
		return -1;
	}
}

extern "C" __declspec(dllexport) double getInputs(int port) 
{
	switch(port){
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
