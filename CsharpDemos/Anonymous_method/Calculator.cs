using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_AnonymousMethod
{
    delegate int ComputeHandler(int a, int b);
     class Calculator
    {
        public int Add(params int[] arr)
        {
            int result = 0;
            foreach (int i in arr)
            {
                result += 1;
            }
            return result;
        }
        public int Compute(int a,int b,ComputeHandler objD)
        {
            int result = -1;
            return result;
        }
    }
}
