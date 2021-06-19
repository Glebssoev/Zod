using System;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main7(string[] args)
        {
            int endloop = 0;
            int[] action = new int[5];
            while (endloop < 5)
            {
                int num = Int32.Parse(Console.ReadLine());
                action[endloop] = num;
                endloop++;
            }
            int height = action.GetLength(0);
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(action[i] + "\t");
            }

            Console.WriteLine($"This is summary {action.Sum()}");

            int[] massive = null;
            massive ??= new int [0];



        }//just for practice

        static void Main2()
        {
            Console.WriteLine("Enter first number");
            float num = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter symbol");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine("\nEnter second number");
            float num2 = Convert.ToSingle(Console.ReadLine());



            float result = 0;
            if (symbol == '-')
            {
                result = num - num2;
            }
            else if (symbol == '*')
            {
                result = num * num2;
            }
            else if (symbol == '/')
            {
                result = num/ num2;
            }
            else if (symbol == '+')
            {
                result = num + num2;
            }
            else
            {
                throw new InvalidOperationException("Unknown operation.");
            }

            Console.WriteLine($"{num} {symbol} {num2} = {result}");
        }//just for practice

        static void Main3()
        {
            int num1 = 0;
            int result = num1 * 10;
            Console.WriteLine(result);
            
            int num, reverse = 0;
            Console.Write("Enter number ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }

            Console.WriteLine("Reverse of Entered number is "+ reverse);
            Console.ReadLine();
        }//just for practice

        static void Main1()
        {
            Console.Write("Please enter your name ");
            string name = Console.ReadLine();
            Console.Write($"{name} please enter your day birth ");
            int day = int.Parse(Console.ReadLine());
            while (true)
            {
                if (day < 1 || day > 31)
                {
                    Console.WriteLine("Please enter your real DAY next time!");
                    break;
                }
                else
                {
                    break;
                }
            }
            Console.Write($"{name} please enter your month birth ");
            int month = int.Parse(Console.ReadLine());
            while (true)
            {
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Please enter real MONTH next time!");
                    break;
                }
                else
                {
                    break;
                }
            }

            ZodiacDetector makeresult = new ZodiacDetector();
            makeresult.Magic(day, month, name);

            int [] myArrayres = {4, 5, 7, 8};
            Console.WriteLine(myArrayres.Max());

        }

    }

    class ZodiacDetector
    {
        public void Magic(int day, int month, string name)
        {
            string result = "Burn in HELL!";
            if (month == 12)
            {
                if (day > 0 && day < 22)
                {
                    result = "Sagittarius";
                }
                else
                {
                    result = "Capricorn";
                }
            }
            else if (month == 1)
            {
                if (day > 0 && day < 20)
                {
                    result = "Capricorn";
                }
                else
                {
                    result = "Aquarius";
                }
            }
            else if (month == 2)
            {
                if (day > 0 && day < 19)
                {
                    result = "Aquarius";
                }
                else
                {
                    result = "Pisces";
                }
            }
            else if (month == 3)
            {
                if (day > 0 && day < 21)
                {
                    result = "Pisces";
                }
                else
                {
                    result = "Aries";
                }
            }
            else if (month == 4)
            {
                if (day > 0 && day < 20)
                {
                    result = "Aries";
                }
                else
                {
                    result = "Taurus";
                }
            }
            else if (month == 5)
            {
                if (day > 0 && day < 21)
                {
                    result = "Taurus";
                }
                else
                {
                    result = "Gemini";
                }
            }
            else if (month == 6)
            {
                if (day > 0 && day < 21)
                {
                    result = "Gemini";
                }
                else
                {
                    result = "Cancer";
                }
            }
            else if (month == 7)
            {
                if (day > 0 && day < 23)
                {
                    result = "Cancer";

                }
                else
                {
                    result = "leo";
                }
            }
            else if (month == 8)
            {
                if (day > 0 && day < 23)
                {
                    result = "leo";
                }
                else
                {
                    result = "Virgo";
                }
            }
            else if (month == 9)
            {
                if (day > 0 && day < 23)
                {
                    result = "Virgo";
                }
                else
                {
                    result = "Libra";
                }
            }
            else if (month == 10)
            {
                if (day > 0 && day < 23)
                {
                    result = "Libra";
                }
                else
                {
                    result = "Scorpio";
                }
            }
            else if (month == 11)
            {
                if (day > 0 && day < 22)
                {
                    result = "Scorpio";
                }
                else
                {
                    result = "Sagittarius";
                }
            }
            else
            {
                Console.WriteLine("What did you expect?");

            }
            Console.WriteLine($"{name} your zodiac is {result}.");
        }
    }
}
