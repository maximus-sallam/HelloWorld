using System;
using System.Collections.Generic;

namespace HelloWorld
{
    //A Simple Program to display the words Hello, World! this a change
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 12, 1, 5, -2, 16, 14 }; // Source array
            int[] dest = { 1, 2, 3, 4, 5 }; // Array I will call from
            int[] userAge = { 21, 22, 23, 24, 25 }; // Array of ages 
            int[] numbers = { 12, 1, 5, -2, 16, 14 }; // Array of random numbers

            string message = "Hello, Grandma. You're {0} years old!";
            string doYou = "Do you recognize any of these names?";

            string[] separator = { ", ", "; " }; // Adding string separators
            string names = "Rick Ross, Ricky Bobby; Rick James, , Rick Sanchez"; // Let's get Rick Rolled - Adding string of Rick's
            string[] substrings = names.Split(separator,
                StringSplitOptions.RemoveEmptyEntries); // Splitting string of Rick's into substring array

            List<int> userAgeList = new List<int> { 11, 21, 31, 41 }; // List of numbers

            string question = "Choose a number from 1 to 5: ";
            Console.WriteLine(question); // Ask for a number, stored as string
            
            string num = Console.ReadLine(); // Stores number entry to 'num' string
            int newNum = Convert.ToInt32(num); // Converts string to int
            newNum--; // Reduces the value of newNum by one
            Console.WriteLine(message, userAge[newNum]); // You be old. Get that checked out - Prints newNum to console
            
            Array.Copy(source, dest, 3); // Copying first 3 values from 'source' array into 'dest' array
            Array.Sort(numbers); // Sort 'numbers' array

            //Console.WriteLine(dest[3]); // Calling 4th value (4) from 'dest'            
            //Console.WriteLine(numbers[0]); // Calling 1st value (-2) from sorted 'numbers'
            //Console.WriteLine(userAgeList[0]); // Calling 1st value (11) from List
            
            Console.WriteLine(doYou); // Print 'doYou' string
            
            //Console.WriteLine(substrings[0] + "\n" + substrings[3]); // Calling substrings from split string of Rick's
            
            foreach (var item in substrings) // Print substring array to console
            {
                Console.WriteLine(item.ToString());
            }
            Console.Read();
        }
    }
}