using System;

namespace Demo_DataTypes
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int i = 10;
            bool b = true;
            char c = 'a';
            string s = "hello";
            long l = 20L;

            int j = int.MaxValue;
            Console.WriteLine("j={0}",j);
            j = j + 1;
            Console.WriteLine("j={0}", j);

        }
    }
}
