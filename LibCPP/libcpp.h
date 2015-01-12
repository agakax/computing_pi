#ifndef LIBCPP_H
#define LIBCPP_H

#include <iostream>
 
#define DECLDIR __declspec(dllexport)
 
extern "C"
{
   DECLDIR double ComputePart( double x );
}

#endif