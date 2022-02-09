using System;

namespace Demo_ArgumentTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo of Pass By value");
            int a = 10;
            Console.WriteLine("a= {0}",a);
            DemoofPassByvalue(a);
            Console.WriteLine("a after pass by value= {0}", a);
            Console.WriteLine();
            Console.WriteLine("Demo of Pass By Reference");
            int b = 50;
            Console.WriteLine("b= {0}", b);
            DemoofPassByReference(ref b);
            Console.WriteLine("b on returning = {0}", b);
            Console.WriteLine();
        }
        static void DemoofPassByvalue(int i)
        {
            Console.WriteLine("i received = {0}", i);
            i = 20;
            Console.WriteLine("i changed to {0}", i);
        }

        static void DemoofPassByReference(ref int i)
        {
            Console.WriteLine("i received = {0}", i);
            i = 100;
            Console.WriteLine("i changed to {0}", i);
        }
    }
}
