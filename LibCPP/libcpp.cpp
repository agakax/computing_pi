#include "libcpp.h"

#define DLL_EXPORT

using namespace std;

extern "C"
{
   DECLDIR double ComputePart( double x )
   {
      return((pow(-1, x))*(4/((2*x)+1)));
   }
}