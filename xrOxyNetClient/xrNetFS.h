/*********************************************************
* Copyright (C) OXYGEN TEAM, 2018. All rights reserved.
* X-Ray Oxygen - Open-source X-Ray Engine Fork
* Apache license
**********************************************************
* Module Name: X-Ray Net Filesystem
**********************************************************
* xrNetFS.h
* Network filesystem implementation
*********************************************************/
#pragma once
#include <windows.h>
#include <string>

class NetFileSystem
{
public:
	NetFileSystem()
	{
		size_t LocalSize = 0;
		TCHAR LocalString[256] = { 0 };
		GetLocalHash(TEXT("xrCore.dll"), LocalString, sizeof(TCHAR) * 256, LocalSize);

#ifdef UNICODE
		CurrentHash = std::wstring(LocalString, LocalSize);
#else
		CurrentHash = std::string(LocalString, LocalSize);
#endif
	}
	
	bool ScanLibraries();
	bool UpdateLibraries();
	bool IsLibrariesIsNew();
	
	void GetLocalHash(LPCTSTR ModuleName, LPCTSTR HashString, size_t StringSize, size_t& HashSize);
	LPTSTR GetLastHash() { /*#TODO: PLEASE GIPERION GIVE ME FUCKING NETWORK LIBRARY*/ };
	void GetDataFromServer(void*& pData, size_t& DataSize, bool IsPacked) { /*#TODO: IT'S NOT ANY FUCKING JOKE*/ }
	void UnpackZip(void* pData, size_t ArchiveSize, void*& pOutData, size_t& UnpackedData);

private:
#ifdef UNICODE
	std::wstring CurrentHash;
#else
	std::string CurrentHash;
#endif
};
