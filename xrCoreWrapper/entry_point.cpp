////////////////////////////////////////
// OXYGEN TEAM, 2018 (C) * X-RAY OXYGEN	
// entry_point.cpp - entry point of xrPlay
// Created: 19 Dec, 2018						
////////////////////////////////////////
#include <windows.h>
/// <summary> Dll import </summary>
using IsRunFunc = char*(__cdecl*)();
char* g_Hash;


/// <summary> Main method for initialize xrEngine </summary>
extern "C"
{
	__declspec(dllexport) char* GetLocalHash(const char* ModuleName)
	{
		//MessageBox(nullptr, ModuleName, "Init error", MB_OK | MB_ICONERROR);
		HMODULE hLib = LoadLibrary(ModuleName);
		if (hLib == nullptr)
		{
			MessageBox(nullptr, "Can't load xrCore.dll!", "Init error", MB_OK | MB_ICONERROR);
			return "Unknown!";
		}

		IsRunFunc RunFunc = (IsRunFunc)GetProcAddress(hLib, "GetCurrentHash");
		if (RunFunc)
		{
			g_Hash = RunFunc(); 
			//MessageBox(nullptr, g_Hash, "Init error", MB_OK | MB_ICONERROR);

			return g_Hash;
		}
		else
		{
			MessageBox(nullptr, "xrCore module doesn't seems to have GetCurrentHash entry point. Different DLL?", "Init error", MB_OK | MB_ICONERROR);
			return "Unknown!";
		}
	}
}