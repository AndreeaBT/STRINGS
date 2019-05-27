using System;
using System.Linq;
using static System.Net.WebRequestMethods;

namespace STRINGS
{
    class Program
    {
        static void Main(string[] args)
        {

            RemoveAnIndex();
            RemoveOddIndexValue();
            UpperAndLowerInput();
            ReverseMultipleOfFourString();
            ReverseString();
            
        }


        static void RemoveAnIndex()
        {

            var myString = "This is a phrase to get used to string manipulation!";

            Console.WriteLine(myString.Remove(5, 12));
        }



        public static void RemoveOddIndexValue()
        {

            string myFirst = "This is a string to get used to string manipulation!";
            string mySecond = "";
            char[] Third = myFirst.ToArray();
            for (int i = 0; i < Third.Length; i++)
            {
                if (i % 2 == 1)
                {
                    mySecond += Third[i].ToString();
                }

            }
            Console.WriteLine(mySecond);
        }



        public static void UpperAndLowerInput()
        {
            var myString = "This is a phrase to get used to string manipulation!";
            Console.WriteLine(myString.ToLower());

            Console.WriteLine(myString.ToUpper());
        }



        public static void ReverseMultipleOfFourString()
        {
            string myFirst = "This";
            string mySecond = "";
            char[] Third = myFirst.ToArray();
            
            for (int i = 0; i < Third.Length; i++)
            {
                if (Third.Length % 4 == 0)
                {
                    mySecond += Third[i].ToString();
                }
                else 
                {
                    Console.WriteLine($"The length of this string is not a mutiple of 4!");
                }
            }
            Console.WriteLine(new string(mySecond.Reverse().ToArray()));
        }



        public static void UpperCaseInTheFirstTwo()
        {
            
        }



        public static void ReverseString()
        {
            var myString = "This is a phrase to get used to string manipulation!";
            Console.WriteLine(new string(myString.Reverse().ToArray()));

        }

    }
}
