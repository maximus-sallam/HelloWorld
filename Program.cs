using System;

namespace HelloWorld
{
    //A Simple Program to display the words Hello, World! this a change
    class Program
    {
        static void Main(string[] args)
        {
            int[] userAge = { 21, 22, 23, 24, 25 }; // Declaration
            Console.WriteLine("Hello, grandma! You're " + userAge[4] + " years old!");
            Console.Read();
        }
    }
}