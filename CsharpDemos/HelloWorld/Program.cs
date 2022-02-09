using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Welcome to .NET Series Concept");
            Console.WriteLine("First Example of CSharp");

            Console.Write(" 1. Enter Your name:- ");
            String name =  Console.ReadLine();

            Console.Write(" 2. Enter Your age :- ");
            int age = int .Parse(Console.ReadLine());

            Console.WriteLine("Hi {0} , You are {1} Years young!", name,age);
        }
    }
}
