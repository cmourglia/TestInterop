#pragma once

#if defined BACKEND_EXPORT
#	define EXPORT __declspec(dllexport)
#else
#	define EXPORT __declspec(dllimport)
#endif

extern "C" {
	EXPORT int Computation1();
	EXPORT int Computation2();
}