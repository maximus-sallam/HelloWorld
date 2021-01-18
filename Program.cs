using System;

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

            Console.WriteLine("Hello, grandma! You're " + userAge[4] + " years old!"); // You be old. Get that checked out.
            
            Array.Copy(source, dest, 3); // Copying first 3 values from 'source' into 'dest'
            Array.Sort(numbers); // Sort list of 'numbers'

            /* Commenting during testing -----
            Console.WriteLine(dest[3]); // Calling 4th value from 'dest'
            ----- Commenting during testing */
            
            Console.WriteLine(numbers[0]); // Calling 1st value from sorted 'numbers'

            Console.Read();
        }
    }
}