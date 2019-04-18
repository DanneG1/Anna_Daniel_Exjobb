#include "stdafx.h"
#include "C:\Users\Danne\Documents\MATLAB\addition_times_5_v2_ert_rtw\addition_times_5_v2.h"
#include "C:\Users\Danne\Documents\MATLAB\addition_times_5_v2_ert_rtw\addition_times_5_v2.cpp"

  addition_times_5ModelClass rObj;


//extern "C" __declspec(dllexport) !functionType !functionName( !parameters )

extern "C" __declspec(dllexport) void initialize() 
{
	rObj.initialize();
}

extern "C" __declspec(dllexport) void setInputs(int port,double value) 
{
//Skapa switchcases baserat p� antalet portar och nytt v�rde.

/*Exempel 
	switch (port) {
	case 0:
		rObj.trippleinput_different_dataty_U.Input1_signal = value;
		break;
	}*/

	switch(port){
case 0:
rObj.addition_times_5_v2_U.Inport1 = value;
break;
case 1:
rObj.addition_times_5_v2_U.Inport2 = value;
break;
	}
}

extern "C" __declspec(dllexport) double getOutputs(int port) 
{
//Skapa switchcase f�r att returnera angiven output

/*Exempel:
	switch (port) {
	case 0:
		return rObj.trippleinput_different_dataty_Y.Addition_output;
	}*/
	switch(port){
case 0:
 return rObj.addition_times_5_v2_Y.Output1 ;
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
