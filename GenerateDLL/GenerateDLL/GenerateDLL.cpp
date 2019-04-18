// GenerateDLL.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "C:\Users\Anna Forsberg\MATLAB\Projects\testproject\work\codegen\addition_ert_rtw\addition.h"
#include "C:\Users\Anna Forsberg\MATLAB\Projects\testproject\work\codegen\addition_ert_rtw\addition.cpp"
additionModelClass rObj;


//extern "C" __declspec(dllexport) !functionType !functionName( !parameters )

extern "C" __declspec(dllexport) void initialize()
{
	rObj.initialize();
}

extern "C" __declspec(dllexport) void setInputs(int port, double value)
{
	//Skapa switchcases baserat p� antalet portar och nytt v�rde.

	/*Exempel
	switch (port) {
	case 0:
	rObj.trippleinput_different_dataty_U.Input1_signal = value;
	break;
	}*/

	switch (port) {
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
	//Skapa switchcase f�r att returnera angiven output

	/*Exempel:
	switch (port) {
	case 0:
	return rObj.trippleinput_different_dataty_Y.Addition_output;
	}*/
	switch (port) {
	case 0:
		return rObj.rtY.Out1;
	default:
		return 0;
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

