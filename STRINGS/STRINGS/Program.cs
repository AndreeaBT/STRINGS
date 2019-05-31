using System;
using System.Linq;
using System.Text;
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
            ReverseStringIfMultipleOfFour();
            ReverseString();
            UpperCaseInTheFirstTwoCharacters();
            CheckIfStringIsPalindrome();


        }

       

        

        static void RemoveAnIndex()
        {

            string myString ="This is a phrase to get used to string manipulation!";
            
            Console.WriteLine(myString.Remove(4, 1));
        }



        public static void RemoveOddIndexValue()
        {

            string myFirst = "This is a string to get used to string manipulation!";
            string mySecond = "";
            char[] Third = myFirst.ToArray();
            for (int i = 0; i < Third.Length; i++)
            {
                if (i % 2 == 0)
                {
                    mySecond += Third[i].ToString();
                }

            }
            Console.WriteLine(mySecond);
        }



        public static void UpperAndLowerInput()
        {
            string myString ="This is a phrase to get used to string manipulation!";
            Console.WriteLine(myString.ToLower());

            Console.WriteLine(myString.ToUpper());
        }



        public static void ReverseStringIfMultipleOfFour()
        {
            Console.WriteLine("Please type something for the ReverseStringIfMultipleOfFour method!");
            string myFirst = Console.ReadLine();
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
                    Console.WriteLine($"The length of \" {myFirst}\" is not a mutiple of 4!");
                    return;
                }
            }
            Console.WriteLine(new string(mySecond.Reverse().ToArray()));
        }



        public static void UpperCaseInTheFirstTwoCharacters()
        {
            Console.WriteLine("Please type something for the \" UpperCaseInTheFirstTwoCharacters method!\"");
            string Line = Console.ReadLine();
            for (int i = 0; i < Line.Length; i++)
            {
                string New = "";
                if (char.IsUpper(Line[0]) && char.IsUpper(Line[1]))
                {
                    New = New + Line.ToUpper().ToString();
                   
                }
                
                else
                {
                    Console.WriteLine($"The string \" {Line}\" doesn't have the first two characters written in uppercase!");
                    return;
                }
                //Console.WriteLine(New);
                Console.WriteLine($"The string \" {New}\" has the first two characters written in uppercase!");
            }
        }



        public static void ReverseString()
        {
            var myString = "This is a phrase to get used to string manipulation!";
            Console.WriteLine(new string(myString.Reverse().ToArray()));
           
        }

        public static void CheckIfStringIsPalindrome()
        {
            Console.WriteLine("Please type something for the ChechIfStringIsPalindrome method!");
            string Line = Console.ReadLine();
            Console.WriteLine(Line);
            int l = 0;
            int h = Line.Length - 1;
            while (h > l)
            {
                if (Line[l++] != Line[h--])
                {
                    Console.WriteLine($"{Line} is Not Palindrome");
                    return;
                }
            }
            Console.WriteLine($"{Line} is palindrome");
        }



    }


    
}
