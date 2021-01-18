using System;
using System.Collections.Generic;

namespace HelloWorld
{
    //A Simple Program to display the words Hello, World! this a change
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 12, 1, 5, -2, 16, 14 }; // Source numbers
            int[] dest = { 1, 2, 3, 4, 5 }; // Numbers I will call from
            int[] userAge = { 21, 22, 23, 24, 25 }; // Declaration of age
            int[] numbers = { 12, 1, 5, -2, 16, 14 };

            string message = "Hello, Grandma. You're ";
            string anotherMessage = " years old!";
            string consoleMessage = message + userAge[4] + anotherMessage;

            List<int> userAgeList = new List<int> { 11, 21, 31, 41 };

            Console.WriteLine(consoleMessage); // You be old. Get that checked out
            
            Array.Copy(source, dest, 3); // Copying first 3 values from 'source' into 'dest'
            Array.Sort(numbers); // Sort list of 'numbers'

            Console.WriteLine(dest[3]); // Calling 4th value from 'dest'            
            Console.WriteLine(numbers[0]); // Calling 1st value from sorted 'numbers'
            Console.WriteLine(userAgeList[0]);
            
            Console.Read();
        }
    }
}