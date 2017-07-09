using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BasicExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateMenu();
            //RemoveString();
            //NewStringOfTwoCharacters();
            //NearestValue();
            //FindLoestAndLargest();
            //ConvertUpperCase();
            //LengthOfString();
            OddPositionOfChracter();
            Console.ReadLine();
            //CheckRange();
            Run:
            ConsoleKey key = ReadMenue();
            RunAssignment(key);

            if (key != ConsoleKey.Z)
            {
                goto Run;
            }

        }


        private static void CreateMenu()
        {

            Console.WriteLine("01 - Press 1 to run write hello and name in new line.");
            Console.WriteLine("02 - Press 2 to run sum of two numbers.");
            Console.WriteLine("03 - Press 3 to run dividing numbers .");
            Console.WriteLine("04 - Press 4 to run Specified Operations.");
            Console.WriteLine("05 - Press 5 to run swapping of two numbers.");
            Console.WriteLine("06 - Press 6 to run multiplication of three numbers.");
            Console.WriteLine("07 - Press 7 to run Arithmetic operation");
            Console.WriteLine("08 - Press 8 to run MultiplicationTable.");
            Console.WriteLine("09 - Press 9 to run PrintAverage.");
            Console.WriteLine("A - Press A to run Solve Expression");
            Console.WriteLine("B - Press B to run Age");
            Console.WriteLine("C - Press C to separated by blank spaces.");
            Console.WriteLine("D - Press D to  DisplaysARectangle.");

            Console.WriteLine("E - Press E to ConvertFromCelsiusToKelvin.");
            Console.WriteLine("F - Press F to Remove Specified Character.");
            Console.WriteLine("G - Press G to Insert A New String.");
            Console.WriteLine("H - Press H to  run Change The Positions.");
            Console.WriteLine("I - Press I to Negative And One Is Positive.");
            Console.WriteLine("J - Press J to run Triple");
            Console.WriteLine("K - Press K to  Absolute Value.");
            Console.WriteLine("L - Press L to run summing.");

            Console.WriteLine("M - Press G to  Less And Greater Number.");
            Console.WriteLine("N - Press H to  run Change The Positions.");
            Console.WriteLine("O - Press I to Negative And One Is Positive.");
            Console.WriteLine("P - Press J to Check Range");
            Console.WriteLine("Q - Press K to  Absolute Value.");
            Console.WriteLine("R - Press L to run Absolute Value.");

            Console.WriteLine("S - Press G to Insert A New String.");
            Console.WriteLine("T - Press H to  run Change The Positions.");
            Console.WriteLine("U - Press I to Negative And One Is Positive.");
            Console.WriteLine("V - Press J to run Triple");
            Console.WriteLine("W - Press K to  Absolute Value.");
            Console.WriteLine("X - Press L to run Absolute Value.");
            Console.WriteLine("Y - Press L to run Absolute Value.");




            Console.WriteLine("00 - Press Z to exit the program.");

        }


        private static ConsoleKey ReadMenue()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine("01 - Press 1 to run write hello and name in new line.");
            return key.Key;
        }

        //Run Assignments

        private static void RunAssignment(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    WriteHelloAndNameInNewLine();
                    break;
                case ConsoleKey.D2:
                    SumTwoNumbers();
                    break;
                case ConsoleKey.D3:
                    dividingtwoNumbers();
                    break;
                case ConsoleKey.D4:
                    SpecifiedOperations();
                    break;
                case ConsoleKey.D5:
                    SwapTwoNumbers();
                    break;
                case ConsoleKey.D6:
                    MultiplicationOfThreeNumbers();
                    break;
                case ConsoleKey.D7:
                    ArithMeticOperation();
                    break;
                case ConsoleKey.D8:
                    MultiplicationTable();
                    break;
                case ConsoleKey.D9:
                    PrintAverage();
                    break;
                case ConsoleKey.A:
                    SolveExpression();
                    break;
                case ConsoleKey.B:
                    Age();
                    break;
                case ConsoleKey.C:
                    SeparatedByBlankspaces();
                    break;
                case ConsoleKey.D:
                    DisplaysARectangle();
                    break;
                case ConsoleKey.E:
                    ConvertFromCelsiusToKelvin();
                    break;
                case ConsoleKey.F:
                    RemoveSpecifiedCharacter();
                    break;
                case ConsoleKey.G:
                    InsertANewString();
                    break;
                case ConsoleKey.H:
                    ChangeThePositions();
                    break;
                case ConsoleKey.I:
                    NegativeAndOneIsPositive();
                    break;
                case ConsoleKey.J:
                    Triple();
                    break;
                case ConsoleKey.K:
                    AbsoluteValue();
                    break;
                case ConsoleKey.L:
                    summing();
                    break;
                case ConsoleKey.M:
                    ConvertIntoLowercase();
                    break;
                case ConsoleKey.N:
                    IntegerBetweenRange();
                    break;
                case ConsoleKey.O:
                    FindTheLongestWord();
                    break;
                case ConsoleKey.P:
                    OddNumbers();
                    break;
                case ConsoleKey.Q:
                    SumOfPrimeNumbers();
                    break;
                case ConsoleKey.R:
                    print();
                    break;
                case ConsoleKey.S:
                    ReverseString();
                    break;
                case ConsoleKey.T:
                    FileSize();
                    break;
                case ConsoleKey.U:
                    ConvertDecimal();
                    break;
                case ConsoleKey.V:
                    CopiesOfNewString();
                    break;
                case ConsoleKey.W:
                    MultipleOfPositiveNum();
                    break;
                case ConsoleKey.X:
                    SpecifiedWord();
                    break;
                case ConsoleKey.Y:
                    LessAndGreaterNumber();
                    break;

                case ConsoleKey.Z:
                    Console.WriteLine("Bye bye");
                    break;
                default:
                    break;

            }
        }

        /// Write Hello And Name In NewLine

        private static void WriteHelloAndNameInNewLine()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Maryam Kalsoom");
        }

        /// Sum Two Numbers

        private static void SumTwoNumbers()
        {
            Console.WriteLine("Enter the first number.");
            int number1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number.");
            int number2 = Int32.Parse(Console.ReadLine());


            int sum = number1 + number2;

            Console.WriteLine("Sum is {0} : " + sum);


        }

        /// Dividing two numbers

        private static void dividingtwoNumbers()
        {
            Console.WriteLine("dividing numbers");
            Console.WriteLine("Enter First number");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            int num2 = Int32.Parse(Console.ReadLine());

            int div = num1 / num2;
            Console.WriteLine("Result of dividing numbers is {0}", div);

        }

        /// result of the specified operations

        private static void SpecifiedOperations()
        {
            Console.WriteLine("specified operations");
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);

            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

        }

        //Swapping

        private static void SwapTwoNumbers()
        {
            Console.WriteLine("Enter first number");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Int32.Parse(Console.ReadLine());

            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping");
            Console.WriteLine(" first number is: {0}", num1);
            Console.WriteLine(" second number is: {0}", num2);

        }

        ///multiplication of three numbers

        private static void MultiplicationOfThreeNumbers()
        {
            ///multiplication of three numbers by the user

            Console.WriteLine("Enter First number");
            int number1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" Enter Second number");
            int number2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number");
            int number3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("multiplication of three numbers is:");
            Console.WriteLine(number1 * number2 * number3);

        }

        ///Arithmetic operations

        private static void ArithMeticOperation()
        {
            Console.WriteLine("Enter first number");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = Int32.Parse(Console.ReadLine());

            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;

            Console.WriteLine("a+b :{0}", c);
            Console.WriteLine("a-b :{0}", d);
            Console.WriteLine("a*b :{0}", e);
            Console.WriteLine("a/b :{0}", f);
        }

        ///Print  multiplication table

        private static void MultiplicationTable()
        {

            Console.WriteLine("enter a table value");
            int j = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} *{1}= {2}", j, i, i * j);
            }
        }

        ///print the average of four numbers

        private static void PrintAverage()
        {
            Console.WriteLine("Enter first number");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number");
            int c = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter fourth number");
            int d = Int32.Parse(Console.ReadLine());

            int result = (a + b + c + d) / 4;
            Console.WriteLine("The average of {0} , {1} , {2} , {3} is: {4} ", a, b, c, d, result);

        }

        ///Takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z

        private static void SolveExpression()
        {
            Console.WriteLine("enter first number:");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter second number:");
            int y = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter third number:");
            int z = Int32.Parse(Console.ReadLine());

            int result1;
            result1 = (x + y) * z;
            Console.WriteLine("(x + y) * z = {0}:", result1);

            int result2;
            result2 = x * y + y * z;
            Console.WriteLine("x*y + y*z = {0}", result2);
        }

        ///Takes an age (for example 20) as input and prints something as
        ///"You look older than 20"

        private static void Age()
        {
            Console.WriteLine("Enter age");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("you look older than 20");
        }

        /// enter a  number as input and display it four times in a row (separated by blank spaces),
        /// and then four times in the next row, with no separation

        private static void SeparatedByBlankspaces()
        {
            Console.WriteLine("Enter a digit");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);

            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
        }


        ///  Displays A Rectangle

        private static void DisplaysARectangle()
        {
            Console.WriteLine("Enter a number:");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} {0} {0}", n);
            Console.WriteLine("{0} {0}", n);
            Console.WriteLine("{0} {0}", n);
            Console.WriteLine("{0} {0}", n);
            Console.WriteLine("{0} {0} {0}", n);
        }


        ///C# program to convert from celsius degrees to Kelvin and Fahrenheit

        private static void ConvertFromCelsiusToKelvin()
        {
            //Celsius amount will be 30
            Console.WriteLine("Enter amount of degree");
            int c = Int32.Parse(Console.ReadLine());

            //convert Celsius to Kelvin

            int k = 273 + 30;
            Console.WriteLine("Kelvin is:{0}", k);

            // convert Celsius to Fahrenheit

            double f = (1.8 * c) + 32;
            Console.WriteLine("Fahrenheit is:{0}", f);
        }

        ///program remove specified a character from a non-empty string using index of a character

        private static void RemoveSpecifiedCharacter()
        {
            string str = "w3school";
            System.Console.WriteLine(str.Substring(0, 7));
            System.Console.WriteLine(str.Substring(1, 7));

            System.Console.WriteLine(str.Substring(0, 6));
            System.Console.WriteLine(str.Replace("w", "G"));

            //Something Changed
            //acbgffd
            //bvbcfgc

        }

        ///create a new string from a given string where the first 
        ///and last characters will change their positions

        private static void ChangeThePositions()
        {
            string mystring = "Python";
            Console.WriteLine(mystring.Substring(mystring.Length - 1) + mystring.Substring(1, mystring.Length - 2) + mystring.Substring(0, 1));
            string mystring1 = "w3resource";
            Console.WriteLine(mystring1.Substring(mystring1.Length - 1) + mystring1.Substring(1, mystring1.Length - 2) + mystring1.Substring(0, 1));
            Console.WriteLine("x");
        }

        ///program to create a new string from a given string (length 1 or more )
        ///with the first character added at the front and back

        private static void InsertANewString()
        {
            string mystring = "The quick brown fox jumps over the lazy dog. ";
            char mychar = 'T';
            string addstring = mychar + mystring + mychar;
            Console.WriteLine(addstring);

        }

        ///check two given integers and return true if one is negative and one is positive

        private static void NegativeAndOneIsPositive()
        {

            Console.WriteLine("Enter a negtive number");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a positive number");
            int num2 = Int32.Parse(Console.ReadLine());

            if (num1 < 0 && num2 > 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }

        ///Write a C# program to compute the sum of two given integers,
        ///if two values are equal then return the triple of their sum.

        private static void Triple()
        {

            Console.WriteLine("enter a number");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter a number");
            int num2 = Int32.Parse(Console.ReadLine());

            int sum = 0;
            sum = num1 + num1;
            Console.WriteLine("sum is {0}", sum);
            if (num1 == num2)
            {
                Console.WriteLine("triple of their sum is");
                Console.WriteLine((num1 + num2) * 3);

            }
            else
            {
                Console.WriteLine("wrong");
            }

        }


        /// absolute value of the difference between two given numbers.And
        ///Return double the absolute value 

        private static void AbsoluteValue()
        {
            Console.WriteLine("enter first number");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2 = Int32.Parse(Console.ReadLine());


            if (num1 > num2)
            {
                Console.WriteLine(" Double Absolute value is:");
                Console.WriteLine((num1 + num2) * 3);
            }
            else
            {
                Console.WriteLine(num2 - num1);
            }
        }

        ///the sum of the two given integers and return true
        ///if one of the integer is 20 or if their sum is 20.

        private static void summing()
        {

            Console.WriteLine("enter first itegers");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter second itegers");
            int y = Int32.Parse(Console.ReadLine());

            Console.WriteLine(x == 20 || y == 20 || x + y == 20);

        }


        ///  program to check if an given integer is within 20 of 100 or 200

        private static void IntegerBetweenRange()
        {
            Console.WriteLine("Enter integer");
            int number = Int32.Parse(Console.ReadLine());

            if (number <= 20 || number > 200)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }

        ///  convert a given string into lowercase

        private static void ConvertIntoLowercase()
        {
            string mystring = "MARYAM KALSOOM";

            Console.WriteLine(mystring.ToLower());
        }

        /// find the longest word in a string

        private static void FindTheLongestWord()
        {
            string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);

        }

        /// Odd numbers from 1 to 99..

        private static void OddNumbers()
        {
            Console.WriteLine("Odd numbers from 1 to 99. ");
            for (int n = 1; n < (99 + 1); n++)
            {
                if (n % 2 != 0)
                {
                    Console.Write(n.ToString());
                }
            }


        }

        private static void SumOfPrimeNumbers()
        {
            int n = 2, totalPrimeNumbers = 1, x;
            double sumOfPrimes = 2;

            while (n <= 500)
            {
                // test if n is prime
                for (x = 2; x < n; x++)
                {
                    if ((n % x) != 0)
                    {
                        sumOfPrimes = sumOfPrimes + n;
                        totalPrimeNumbers++;
                        // change value of x to end for loop
                        x = n + 1;
                    }
                }
                // increase n by 1 to test next number
                n++;
            }
            Console.WriteLine("Sum - " + sumOfPrimes);

        }
        /// Sum of the digits of the said integer: 3

        private static void print()
        {
            Console.Write("Input  a number(integer): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum);
        }


        private static void ReverseString()
        {
            string s1 = " Display the pattern like pyramid using the alphabet";
            char[] arr = s1.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);

        }
        /// Write a C# program to find the size of a specified file in bytes

        private static void FileSize()
        {
            // Make a reference to a directory.
            DirectoryInfo di = new DirectoryInfo("C:/Users/kalsoom/Videos");

            // Get a reference to each file in that directory.
            FileInfo[] fiArr = di.GetFiles();

            // Display the names and sizes of the files.
            Console.WriteLine("The directory {0} contains the following files:", di.Name);
            foreach (FileInfo f in fiArr)
                Console.WriteLine("The size of {0} is {1} bytes.", f.Name, f.Length);
        }

        ///convert a decimal number to hexadecimal number

        private static void ConvertDecimal()
        {
            string decValue = "1234";
            string x = int.Parse(decValue).ToString("");
            Console.WriteLine(x);

        }


        private static void CopiesOfNewString()
        {
            string s3 = "Visual C# Express";
            System.Console.WriteLine(s3.Substring(10, 7) + s3.Substring(10, 7) + s3.Substring(10, 7));

        }

        private static void MultipleOfPositiveNum()
        {
            Console.WriteLine("enter positive num");
            int x = Int32.Parse(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine(x % 3 == 0 || x % 7 == 0);
            }
        }

        private static void SpecifiedWord()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine((str.Length < 6 && str.Equals("hello")) || (str.StartsWith("hello") && str[5] == ' '));
        }

        private static void LessAndGreaterNumber()
        {
            Console.WriteLine("Enter number less than 100");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter number Greater than 100");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(num1 <= 100 && num2 >= 100);
        }

        //check if an integer (from the two given integers) is in the range -10 to 10

        private static void CheckRange()
        {
            Console.WriteLine("Input a first number: -5");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input a second number: 8 ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(((num1 >= -10 && num1 <= 10) || (num2 >= -10 && num2 <= 10)));
        }

        ///if "HP" appears at second position in a string and returns the string without "HP"

        private static void RemoveString()
        {
            string mystr = "PHP Tutorial";
            string result = mystr.Remove(1, 2);
            Console.WriteLine(result);

        }

        ///Test Data: PHP
        /// Sample Output:
        //ph

        private static void NewStringOfTwoCharacters()
        {
            Console.WriteLine("new string is:");
            string mystring = "PHP";
            string result = mystring.Remove(2, 1);
            Console.WriteLine(result);
        }


        private static void FindLoestAndLargest()
        {

            Console.WriteLine("Input a first number: 15");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input a second number: 25 ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input a third number: 30 ");
            int num3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("largest number is:");
            Console.WriteLine(Math.Max(num1, Math.Max(num2, num3)));
            Console.WriteLine("lowest number is:");
            Console.WriteLine( Math.Min(num1, Math.Min(num2, num3)));
        }

        /*
        private static void NearestValue()
        {
            Console.WriteLine("Input first integer");
            int number1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input second integer");
            int number2 = Int32.Parse(Console.ReadLine());

            int n = 20;
            if(number1 < n)
            {
                Console.WriteLine(number1);
            }
            else

        }*/

        /// C# program to create a new string where the first 4 characters will be in lower case. 
        /// If the string is less than 4 characters then make the whole string in upper case

        private static void ConvertUpperCase()
        {
            
            Console.WriteLine("Input a string");
            string str = Console.ReadLine();
            if (str.Length <= 4)
            {
                Console.WriteLine(str.ToUpper());
                
            }
            else
            {
                Console.WriteLine("exit");
            }

        }
        /// check if a given string starts with "w" and immediately followed by two "ww"

        private static void LengthOfString()
        {
            Console.WriteLine("input three chrachter");
            string str = Console.ReadLine();
            Console.WriteLine(str.Length <= 3);
        }

        private static void OddPositionOfChracter()
        {
            Console.Write("Input a string : ");
            string str = Console.ReadLine();
            var result = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0) result += str[i];
            }
            Console.WriteLine(result);

        }



    }
}
























