#include "libcpp.h"

#define DLL_EXPORT

using namespace std;

extern "C"
{
   DECLDIR double __stdcall ComputePart( double x )
   {
      return((pow(-1, x))*(4/((2*x)+1)));
   }
}