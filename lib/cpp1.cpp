#include <iostream>
#include <Windows.h>
#include <stdio.h>
#include "h1.h"

int write(const wchar_t* str) {
	wprintf_s(L"%s", str);
	return 0;
}
