////////////////////////////////////////
// OXYGEN TEAM, 2018 (C) * X-RAY OXYGEN	
// entry_point.cpp - entry point of xrPlay
// Created: 19 Dec, 2018						
////////////////////////////////////////

#ifndef OXY_IMPORT
#define OXY_API __declspec(dllexport)
#else
#define OXY_API __declspec(dllimport)
#endif

#include <windows.h>
/// <summary> Dll import </summary>
using IsRunFunc = char*(__cdecl*)();
char* g_Hash;


/// <summary> Main method for initialize xrEngine </summary>
extern "C"
{
	OXY_API PTSTR GetLocalHash(PCTSTR ModuleName)
	{
		static HMODULE hLib = nullptr;
		static IsRunFunc RunFunc = nullptr;

		if (!hLib)
		{
			hLib = LoadLibrary(ModuleName);
			if (!hLib)
			{
				// P.S: Handles - NULL, Pointers - nullptr
				MessageBox(NULL, TEXT("Can't load xrCore.dll!"), TEXT("Init error"), MB_OK | MB_ICONERROR);
				return TEXT("Unknown!");
			}
		}
		
		// don't call GetProcAddress every time: it's can affect on perfomance
		if (!RunFunc)
		{
			RunFunc = (IsRunFunc)GetProcAddress(hLib, "GetCurrentHash");
		}

		if (RunFunc)
		{
			g_Hash = RunFunc(); 
		
			return g_Hash;
		}

		MessageBox(NULL, TEXT("xrCore module doesn't seems to have GetCurrentHash entry point. Different DLL?"), TEXT("Init error"), MB_OK | MB_ICONERROR);
		return TEXT("Unknown!");
	}
}
