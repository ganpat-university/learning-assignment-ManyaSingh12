using System;

namespace Demo_AnonymousMethod

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator objCalc = new Calculator();
            int result;
            result = objCalc.Add();
            result = objCalc.Add(10);
            result = objCalc.Add(10,20,30,40);
            result = objCalc.Compute(100,200,Program.Multiply);
            
            // Anonymous Method
            ComputeHandler objD2 = 
                delegate (int a, int b)
            {
                return a * b;
            };
            result = objCalc.Compute(100, 200, objD2);

            // LAMBDA EXPRESSION
            ComputeHandler objD3 =
                (int a, int b) =>
                {
                    return a * b;
                };
            result = objCalc.Compute(100, 200, objD3);

        }
        private static int Multiply (int a,int b)
        {
            return a * b;
        }
    }
}
