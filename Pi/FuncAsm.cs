using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Pi
{
    unsafe class FuncAsm
    {
        [DllImport("LibASM.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern double compute(double x);          //import funkcji z biblioteki Asemblera

        public double computePartPi(double x)            //publiczna metoda pozwalająca wywołać naszą funkcję.
        {
            double result = compute(x);
            return result;
        }
    }
}
