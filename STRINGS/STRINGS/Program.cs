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
            GetStringFromUser();
        }
        public static void GetStringFromUser()
        {
           
        }
        
        static void RemoveAnIndex()
        {
           
            var myString = "This is a phrase to get used to string manipulation!";

            Console.WriteLine(myString.Remove(5, 12));

        }
        public static void RemoveOddIndexValue()
        {
           
        }
        public static void UpperAndLowerInput()
        {
             var myString = "This is a phrase to get used to string manipulation!";
            Console.WriteLine(myString.ToLower());

            Console.WriteLine(myString.ToUpper());

        }
        public static void ReverseMultipleOfFourString()
        {
            //var myString = "This is a phrase to get used to string manipulation!";
            
        }
        public static void ReverseString()
        {
            var myString = "This is a phrase to get used to string manipulation!";
            Console.WriteLine(new string(myString.Reverse().ToArray()));

        }

   }
}
