#include "stdafx.h"
#include "xrNetFS.h"

using IsRunFunc = LPTSTR(__cdecl*)();
LPTSTR g_Hash;

void
NetFileSystem::GetLocalHash(LPCTSTR ModuleName, LPCTSTR HashString, size_t StringSize, size_t& HashSize)
{
	static HMODULE hLib = nullptr;
	static IsRunFunc RunFunc = nullptr;

	if (!hLib)
	{
		if (!(hLib = GetModuleHandle(ModuleName)))
		{
			hLib = LoadLibrary(ModuleName);
			if (!hLib)
			{
				// P.S: Handles - NULL, Pointers - nullptr
				MessageBox(NULL, TEXT("Can't load xrCore.dll!"), TEXT("Init error"), MB_OK | MB_ICONERROR);
				return;
			}

			// get access to module
			hLib = GetModuleHandle(ModuleName);
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

#ifdef UNICODE
		HashSize = wcslen(g_Hash);	
		memcpy_s((void*)(HashString), StringSize, g_Hash, HashSize * sizeof(wchar_t));	// zero-terminated string
#else
		HashSize = strlen(g_Hash);
		memcpy_s((void*)(HashString), StringSize, g_Hash, HashSize);
#endif
		HashSize++;
		return;
	}

	MessageBox(NULL, TEXT("xrCore module doesn't seems to have GetCurrentHash entry point. Different DLL?"), TEXT("Init error"), MB_OK | MB_ICONERROR);
}

bool
NetFileSystem::ScanLibraries()
{
	if (!GetModuleHandle(TEXT("xrCore")))
	{
		if (!LoadLibrary(TEXT("xrCore"))) { return false; }
	}

	return true;
}

bool
NetFileSystem::IsLibrariesIsNew()
{
	if (ScanLibraries())
	{
		TCHAR LocalString[256] = { 0 };
		LPTSTR StringLastHash = nullptr;
		size_t LocalSize = 0;

		GetLocalHash(TEXT("xrCore.dll"), LocalString, sizeof(TCHAR) * 256, LocalSize);
		StringLastHash = GetLastHash();
#ifdef UNICODE
		if (StringLastHash && !memcmp(StringLastHash, LocalString, wcslen(StringLastHash) * sizeof(wchar_t)))
#else	
		if (StringLastHash && !memcmp(StringLastHash, LocalString, strlen(StringLastHash)))
#endif
		{
			return true;
		}
	}

	return false;
}

//#TODO: мне лень, без либы ничего не буду делать
bool
NetFileSystem::UpdateLibraries()
{
	if (!IsLibrariesIsNew())
	{
		void* pImageData = nullptr;
		size_t ImageSize = 0;
		
		GetDataFromServer(pImageData, ImageSize, false);
		
		if (pImageData && ImageSize)
		{
			size_t UnpackedSize = 0;
			void* Outdata = nullptr;

			UnpackZip(pImageData, ImageSize, Outdata, UnpackedSize);
		}
	}

	return true;
}