using System;
using System.Collections.Generic;
using System.Globalization;
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
            UpperCaseInTheFirstFourCharacters();
            RemoveNewLine();
            ReverseString();
            FormattedWidthText();
            FormatNumberWithPercentage();
            StripSetOfCharacters();
            LowerFirstNCharacters();
            CapitalizeLetters();
            SumOfDigits();
            CleanTheText();
            AddSuffix();
            ObfuscateEmail();
            ReString();
            ReplaceOccurrences();
            SingleStringFromTwoStrings();
            ReplaceNotThatPoor();
            LongestWord();
            LastPart();
            StringStartsWithSpecific();
            CountOccurrencesSubstring();
            SwapCommaAndDot();
            RemoveWhiteSpaces();
            CheckIfStringIsPalindrome();
            
        }





        static void RemoveAnIndex()
        {
            Console.WriteLine("Please type something for the \" RemoveAnIndex\" method! \n Note: The first value of the index 0 will be removed!!!");
            string myString = Console.ReadLine(); ;

            Console.WriteLine(myString.Remove(0, 1));
        }



        public static void RemoveOddIndexValue()
        {
            Console.WriteLine("Please type something (preferably numbers in order)for the \" RemoveOddIndexValue\" method!");
            string myFirst = Console.ReadLine(); ;
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
            Console.WriteLine("Please type something for the \" UpperAndLowerInput\" method!");
            string myString = Console.ReadLine(); ;
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
            return;
        }



        public static void UpperCaseInTheFirstFourCharacters()
        {
            Console.WriteLine("Please type something for the \" UpperCaseInTheFirstFourCharacters method!\"");
            string Line = Console.ReadLine();
            int upperC = 0;
            for (int i = 0; i < 4; i++)
            {
                if (Line[i].ToString().Equals(Line[i].ToString().ToUpper()))
                {
                    upperC++;

                    if (upperC >= 2)
                    {
                        Console.WriteLine($"The modified string : {Line.ToUpper()}");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine($"The string \"{Line}\" is too short or doesn't have uppercases in the first four characters!");
                    return;
                }
            }

        }

        public static void RemoveNewLine()
        {
            Console.WriteLine("Please type something for the \" RemoveNewLine\" method!");
            string Line = Console.ReadLine();
            string FinalLine = Line.Replace(Line, " ")/*.Replace("\r", " ")*/;
            Console.WriteLine(FinalLine);
            return;
        }



        public static void FormattedWidthText()
        {
            Console.WriteLine("Please type a veeery long text for the \" FormattedText\" method!");
            string Line = Console.ReadLine();
            int n = 50 - Line.Length % 50;
            for (int i = 1; i <= n; i++)
            {
                Line += " ";
            }

            while (Line.Length >= 50)
            {
                Console.WriteLine(Line.Substring(0, 50));  
                Line = Line.Substring(50);  
            }
            Console.WriteLine(Line);
        }


        public static void FormatNumberWithPercentage()
        {
            decimal Number = -0.987m;
            NumberFormatInfo percentageFormat = new NumberFormatInfo { PercentPositivePattern = 1, PercentNegativePattern = 1 };
            string FormattedValue = Number.ToString("P2", percentageFormat);
            Console.WriteLine(FormattedValue);  
        }



        public static void ReverseString()
        {
            Console.WriteLine("Please type something for the \" reverseString\" method!");
            var myString = Console.ReadLine(); ;
            Console.WriteLine(new string(myString.Reverse().ToArray()));
        }


        public static void StripSetOfCharacters()
        {
            Console.WriteLine("Please type something that contains special characters for the \" StripSetOfCharacters\" method!");
            string Line = Console.ReadLine();
            string removeChars = " ?&^$#@!()+-%:;<>|/|~`,\\{}[].+\'-_*\":=";
            string result = Line;

            foreach (char c in removeChars)
            {
                result = result.Replace(c.ToString(), string.Empty);
            }

            Console.WriteLine($"The cleaned string looks like this : {result}");
        }




        public static void LowerFirstNCharacters()
        {
            Console.WriteLine("Please type something for the \" LowerFirstNCharacters method!\"");
            string Line = Console.ReadLine();
            if (Line.Length < 4)
            {
                Console.WriteLine(Line);
            }
            else
                Console.WriteLine(Line.Substring(0, 4).ToLower() + Line.Substring(4, Line.Length - 4));
        }







        public static void CapitalizeLetters()
        {
            Console.WriteLine("Please type something for the \"CapitalizeLetters\" method!");
            string Line = Console.ReadLine();
            char [] FinalLine = Line.ToArray();
             FinalLine[0] = Char.ToUpper(Line[0]);
            FinalLine[Line.Length - 1] = Char.ToUpper(FinalLine[Line.Length - 1]);
            for (int i = 0; i < Line.Length; i++)
            {
                if (FinalLine[i] == ' ')
                {
                    FinalLine[i - 1] = Char.ToUpper(FinalLine[i - 1]);
                    FinalLine[i + 1] = Char.ToUpper(FinalLine[i + 1]);
                }
            }

            Console.WriteLine(FinalLine);
        }


        public static void SumOfDigits()
        {

            Console.WriteLine("Please type some alphanumeric characters for the \"SumOfDigits\" method!");
            string Line = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i <= Line.Length - 1; i++)
            {
                if (Line[i] > '0' && Line[i] <= '9')
                {
                    sum += Line[i] - '0';
                }
            }
            Console.WriteLine($"The sum of digits is : {sum}");

        }


        public static void CleanTheText()
        {
            string Line = "Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.";
            string[] foo = new string[] { "^", ">", "+", "<", "%", "$", "&", "@" };
            foreach (var x in foo)
            {
                Line = Line.Replace(x, " ");
                Line = Line.Replace("  ", " ");
            }
            Console.WriteLine($"This is the cleaned text : \n{Line}");
        }



        public static void AddSuffix()
        {
            Console.WriteLine("Please type something for the \"AddSuffix\" method!");
            string Line = Console.ReadLine();
            string Value = "ing";
            string Value1 = "ly";
            if (Line.EndsWith(Value))
            {
                Line += Value1;
                Console.WriteLine($"The string with the added suffix \"ly\" looks like this : {Line}!");
                return;
            }
            else if (Line.EndsWith(Value1))
            {
                Console.WriteLine($"The string \"{Line}\" already ends with the suffix \"-ly\" !");
                return;
            }
            else if (!Line.EndsWith(Value))
            {
                Line += Value;
                Console.WriteLine($"The string with the added suffix looks like this : {Line}");
                return;
            }
           
        }


        public static void ObfuscateEmail()
        {
            Console.WriteLine("Please type an email address for the \"ObfuscateEmail\" method!");
            string email = Console.ReadLine();
            for (int i = 0; i < email.Length; i++)
            {
                if (!email.Contains("@"))
                {
                    Console.WriteLine("Please type a valid email address!");
                    return;
                }

                else
                {

                    string maskedEmail = string.Format("****{1}", email[0], email.Substring(email.IndexOf('@')));
                    Console.WriteLine($"Your masket email is : {maskedEmail} ");
                    return;
                }

            }

        }


        public static void ReString()
        {
            Console.WriteLine("Please type something for the \"ReString\" method!");
            string Line = Console.ReadLine();
            StringBuilder Final = new StringBuilder();
            for (int i = 0; i < Line.Length; i++)
            {
                if (Line.Length < 2)
                {
                    Console.WriteLine("Empty string!");
                    return;
                }

               
                if (Line.Length >= 2)
                {
                    Final.Append(Line[0].ToString() + Line[1].ToString() + Line[Line.Length - 2].ToString() + Line[Line.Length - 1].ToString());
                    Console.WriteLine($"The modified string looks like this : {Final}");

                    return;
                }
                
            }
        }

        public static void ReplaceOccurrences()
        {
            Console.WriteLine("Please type something for the \"ReplaceOccurrences\" method!");
            string Line = Console.ReadLine();
            StringBuilder Final = new StringBuilder();
            for (int i = 0; i < Line.Length; i++)
            {
                if (Line.Length == 0)
                {
                    Final.Append(Line);
                    Console.WriteLine(Final);
                    
                }
                else if(Line.Length > 0)
                {
                    char firstChar = Line[0];
                    Final.Append (Line[0].ToString() + Line.Substring(1).Replace(firstChar, '$'));
                    Console.WriteLine($"The modified styring looks like this : {Final}");
                    return;
                }
            }
        }



        public static void SingleStringFromTwoStrings()
        {
            Console.WriteLine("Please type something for the first string in the \"SingleStringFromTwoStrings\" method!");
            string Line = Console.ReadLine();
            Console.WriteLine("Please type something for the second string in the \"SingleStringFromTwoStrings\" method!");
            string LineTwo = Console.ReadLine();
            StringBuilder Final = new StringBuilder();

                if ((Line.Length == 0 || LineTwo.Length == 0))
                {
                    Console.WriteLine("There must be two strings for this method to work!");
                    return;
                }
                else if ((Line.Length == 1 || LineTwo.Length == 1))
                {
                Console.WriteLine("The lenght of each string must be at least 2 characters!");
                return;
                }
                else if (Line.Length > 0 && LineTwo.Length > 0)
                {
                    Final.Append(LineTwo[0].ToString() + LineTwo[1].ToString() + Line.Substring(2) + " " + Line[0] + Line[1] + LineTwo.Substring(2));
                    Console.WriteLine($"The modified string looks like this : {Final}");
                    return;
                }
            
           

        }


        public static void ReplaceNotThatPoor()
        {
            Console.WriteLine("Please type a phrase that includes the words \'not\' and \'that poor\' for the \"ReplaceNotAndPoor\" method!");
            string Line = Console.ReadLine();
            
            StringBuilder Final = new StringBuilder();
            for (int i = 0; i < Line.Length; i++)
            {
                if (!Line.Contains("not") && !Line.Contains(" that poor"))
                {
                    Console.WriteLine("The phrase doesn't include the neccesary words!");
                    return;
                }
                else if (Line.IndexOf("not") < Line.IndexOf("that poor"))
                {

                    Final.Append(Line.Replace("not that poor", "good"));
                    Console.WriteLine($"The position of \'not\' is ahead of \'that poor\', so the string looks like this : {Final}");
                    return;
                }
                else if (Line.IndexOf("not") > Line.IndexOf("that poor"))
                {
                    Final.Append(Line);
                    Console.WriteLine($"The string remains the same : {Final}");
                    return;
                }
            }



        }


        public static void LongestWord()
        {
            Console.WriteLine("Please type more than one word for the \"Longest word\" method!");
            List<string> List = new List<string>();
            List.Add(Console.ReadLine());
            List.Add(Console.ReadLine());
            List.Add(Console.ReadLine());
            StringBuilder Longest = new StringBuilder();
            
            
                if (List.ToString().Length == 0)
                {
                    Console.WriteLine("This method must have at least one word!");
                    return;
                }
                else if (List.ToString().Length > 0)
                {
                    Longest.Append(List.Max());
                    Console.WriteLine($"The longest word is : {Longest}");
                    return;
                }
            
            //string Line = Console.ReadLine();
            //List<string> log = new List<string>();
            //log.Add(Console.ReadLine());
            //log.Add(Console.ReadLine());
            //log.Add(Console.ReadLine());



            //Console.WriteLine("Please type the first word for the \"LongestWord\" method!");
            //string Line = Console.ReadLine();
            //Console.WriteLine("Please type the second word for the \"LongestWord\" method!");
            //string LineTwo = Console.ReadLine();
            //Console.WriteLine("Please type the third word for the \"LongestWord\" method!");
            //string LineThree = Console.ReadLine();
            //StringBuilder Final = new StringBuilder();

            //while (Line.Length > 0 && LineTwo.Length > 0 && LineThree.Length > 0)
            //{
            //    if (Line.Length == 0 || LineTwo.Length == 0 || LineThree.Length == 0)
            //    {
            //        Console.WriteLine("There must be three string for this method to work!");
            //        return;
            //    }
            //    if (Line.Length == LineTwo.Length && LineTwo.Length == LineThree.Length)
            //    {

            //        Console.WriteLine("The lengths of the three words are equal!");
            //        return;
            //    }
            //    else if (Line.Length > LineTwo.Length && LineTwo.Length > LineThree.Length)
            //    {
            //        Final.Append(Line);
            //        Console.WriteLine($"The longest string is : {Final}");

            //        return;
            //}
            //else if (LineTwo.Length > Line.Length && LineTwo.Length > LineThree.Length)
            //{
            //    Final.Append(LineTwo);
            //    Console.WriteLine($"The longest string is : {Final}");

            //    return;
            //}
            //else if (LineThree.Length > Line.Length && LineThree.Length > LineTwo.Length)
            //{
            //    Final.Append(LineThree);
            //    Console.WriteLine($"The longest string is : {Final}");

            //    return;
            //}

            //}
        }


        public static void LastPart()
        {
            Console.WriteLine("Please type a phrase that contains \'-\' !");
            string Line = Console.ReadLine();
            StringBuilder Final = new StringBuilder();
            if (Line.Length == 0)
            {
                Console.WriteLine("You didn't typed anything!");
                return;
            }
            for (int i = 0; i < Line.Length; i++)
            {
               
                if (!Line.Contains("-"))
                {
                    Console.WriteLine("The string doesn't contain \'-\'!");
                    return;
                }
                else if(Line.Length > 1 && Line.Contains("-"))
                {
                    Final.Append(Line.Remove(Line.IndexOf("-")).ToString());
                    Console.WriteLine($"The string without the last part is : {Final}");
                    return;

                }
            }
        }


        public static void StringStartsWithSpecific()
        {
            Console.WriteLine("Please type somethig for the \"StringStartsWithSpecific\" method!");
            string Line = Console.ReadLine();
            if (Line.Length == 0)
            {
                Console.WriteLine("You didn't typed anything!");
                return;
            }
            for (int i = 0; i < Line.Length; i++)
            {
                if (!Line.StartsWith("M"))
                {
                    Console.WriteLine("The phrase you typed doesn't start with \'M\'");
                    return;
                }
                else if (Line.StartsWith("M"))
                {
                    Console.WriteLine("The phrase you typed starts with \'M\'!");
                    return;
                }
            }
        }


       


        public static void CountOccurrencesSubstring()
        {
            Console.WriteLine("Please type somethig for the \'CountOccurencesSubstring\'");
            string Line = Console.ReadLine();
            string Occurence = Line.Substring(Line.IndexOf("rt"));
            StringBuilder Final = new StringBuilder();
            
            
            if(Line.Length == 0)
            {
                Console.WriteLine("You didn't typed anything!");
                return;
            }
            for (int i = 0; i < Line.Length; i++)
            {
                if (!Line.Contains(Occurence))
                {
                    Console.WriteLine("This string doesn't have the substring \'rt\' in it!");
                    return;
                }
                else if (Line.Contains(Occurence))
                {
                    
                    Final.Append(Occurence.Count());
                    Console.WriteLine("The phrase you typed contains \'rt\' this many times : ");
                    return;
                }
            }
        }


       public static void SwapCommaAndDot()
       {
            Console.WriteLine("Please type a phrase that contains a comma (,) and a dot (.)!");
            string Line = Console.ReadLine();
            StringBuilder Final = new StringBuilder();
            if (Line.Length == 0)
            {
                Console.WriteLine("You didn't typed anything!");
                return;
            }
            for (int i = 0; i < Line.Length; i++)
            {
                if (!Line.Contains(",") && !Line.Contains("."))
                {
                    Console.WriteLine("The phrase you typed didn't contained neither a comma(,) or a dot(.)!");
                    return;
                }
                else if(Line.Contains(",") && Line.Contains("."))
                {
                    Final.Append(Line.Replace("," , "." )/*.Replace(".", ",")*/);
                    Console.WriteLine($"The modified string looks like this : {Final}");
                    return;
                }
            }
       }


        public static void RemoveWhiteSpaces()
        {
            Console.WriteLine("Please type something for the \'RemoceWhiteSpaces\' method!");
            string Line = Console.ReadLine();
            StringBuilder Final = new StringBuilder();
            if(Line == string.Empty)
            {
                Console.WriteLine("You didn't typed anything!");
                return;
            }
            else if(Line.Length >= 1)
            {
                Final.Append(Line.Replace(" " , string.Empty));
                Console.WriteLine($"The modified string looks like this : {Final}");
                return;
            }
        }






        public static void CheckIfStringIsPalindrome()
        {
            Console.WriteLine("Please type something for the \" ChechIfStringIsPalindrome\" method!");
            string Line = Console.ReadLine();
            
            int l = 0;
            int h = Line.Length - 1;
            while (h > l)
            {
                
                if (Line[l++] != Line[h--])
                {
                    Console.WriteLine($"\"{Line}\" is Not Palindrome");

                    return;
                    
                }
            }
            Console.WriteLine($"The string \"{Line}\" is a palindrome!");

        }



    }
}
