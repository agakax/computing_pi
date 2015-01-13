using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Pi
{
    unsafe class FuncCpp
    {
        [DllImport("LibCPP.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern double ComputePart(double x);
        //Cdecl
        //$(SolutionDir)$(Configuration)\

        public double computePartPi(double x)
        {
            double result = ComputePart(x);
            return result;
        }
    }
}
