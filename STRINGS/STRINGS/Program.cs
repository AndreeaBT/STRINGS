using System;
using System.Collections.Generic;

namespace STRINGS
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Write a method to remove the n-th index from a nonempty string
            string myString = "Some text to get used to strings!";
            Console.WriteLine(myString.Remove(5, 1));

            //Write a method to remove the characters which have odd index values of a given string.
           
            //Write a method that takes input from the user and displays that input back in upper and lower cases.
            Console.WriteLine(myString.ToLower());

            Console.WriteLine(myString.ToUpper());


            //Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.



        }
    }
}
