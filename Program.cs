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
            string consoleMessage = message + userAge[4] + anotherMessage; // Consolidate parts of message
            string doYou = "Do you recognize any of these names?";

            string[] separator = { ", ", "; " }; // Adding string separators
            string names = "Rick Ross, Ricky Bobby; Rick James, , Rick Sanchez"; // Let's get Rick Rolled - Adding string of Rick's
            string[] substrings = names.Split(separator,
                StringSplitOptions.RemoveEmptyEntries); // Splitting string of Ricks into substrings

            List<int> userAgeList = new List<int> { 11, 21, 31, 41 }; // List of numbers

            Console.WriteLine(consoleMessage); // You be old. Get that checked out
            
            Array.Copy(source, dest, 3); // Copying first 3 values from 'source' into 'dest'
            Array.Sort(numbers); // Sort list of 'numbers'

            Console.WriteLine(dest[3]); // Calling 4th value (4) from 'dest'            
            Console.WriteLine(numbers[0]); // Calling 1st value (-2) from sorted 'numbers'
            Console.WriteLine(userAgeList[0]); // Calling 1st value (11) from List
            Console.WriteLine(doYou); // Print 'doYou' string
            Console.WriteLine(substrings[0] + "\n" + substrings[3]); // Calling substrings from split string of Rick's
            foreach (var item in substrings) // Print substring array to console
            {
                Console.WriteLine(item.ToString());
            }
            Console.Read();
        }
    }
}