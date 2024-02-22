using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_numbers___lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // random 5 numbers
            Random genorator = new Random();
            int min, max, rollOne, rollTwo, bats, decimals, wholeNum;
            double dec, zeroes;
            string phrase;
            Console.WriteLine("Good day user, 'ope all is sweet as a cup of tea, blimey! Please enter a value to be your maximum number (whole numbers");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Arr matey return me booty, by booty I mean a number that's lower then your first choice. (whole number only ARRRGH)");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"HQ says you got incoming numbers between your values! ... {genorator.Next(min,max + 1)}, {genorator.Next(min, max + 1)}, {genorator.Next(min, max + 1)}, {genorator.Next(min, max + 1)}, {genorator.Next(min,max+1)}" );

            // roll a dice
            Console.WriteLine("If you really love to roll dice, this would be a blast of dopamine");
            rollOne = genorator.Next(1, 6);
            if (rollOne == 1)
            {
                Console.WriteLine("-----\r\n|   |\r\n| o |\r\n|   |\r\n-----");
            }
            else if (rollOne == 2)
            {
                Console.WriteLine("-----\r\n|o  |\r\n|   |\r\n|  o|\r\n-----");
            }
            else if (rollOne == 3)
            {
                Console.WriteLine("-----\r\n|o  |\r\n| o |\r\n|  o|\r\n-----");
            }
            else if (rollOne == 4)
            {
                Console.WriteLine("-----\r\n|o o|\r\n|   |\r\n|o o|\r\n-----");
            }
            else if (rollOne == 5)
            {
                Console.WriteLine("-----\r\n|o o|\r\n| o |\r\n|o o|\r\n-----");
            }
            else if (rollOne == 6)
            {
                Console.WriteLine("-----\r\n|o o|\r\n|o o|\r\n|o o|\r\n-----");
            }
            rollTwo = genorator.Next(1, 6);
            if (rollTwo == 1)
            {
                Console.WriteLine("-----\r\n|   |\r\n| o |\r\n|   |\r\n-----");
            }
            else if (rollTwo == 2)
            {
                Console.WriteLine("-----\r\n|o  |\r\n|   |\r\n|  o|\r\n-----");
            }
            else if (rollTwo == 3)
            {
                Console.WriteLine("-----\r\n|o  |\r\n| o |\r\n|  o|\r\n-----");
            }
            else if (rollTwo == 4)
            {
                Console.WriteLine("-----\r\n|o o|\r\n|   |\r\n|o o|\r\n-----");
            }
            else if (rollTwo == 5)
            {
                Console.WriteLine("-----\r\n|o o|\r\n| o |\r\n|o o|\r\n-----");
            }
            else if (rollTwo == 6)
            {
                Console.WriteLine("-----\r\n|o o|\r\n|o o|\r\n|o o|\r\n-----");
            }
            Console.WriteLine("Your lucky number is "+ (rollOne + rollTwo) +"! remember that.");

            //Random Decimal numbers
            Console.WriteLine();
            Console.WriteLine("AH a bowler is headed our way, quick check out these numbers!");
            Console.WriteLine("If logs were decimals, how many logs Would you have? (1-5)");
            decimals = Convert.ToInt32(Console.Read());
            for (int i = 0; i < 3; i++)
            {
                if (decimals == 1)
                {
                    wholeNum = genorator.Next(min, max);
                    zeroes = genorator.NextDouble();
                    phrase = Convert.ToString(Math.Round((Convert.ToDouble(wholeNum) + zeroes), 1));
                    Console.WriteLine(phrase);
                }
                if (decimals == 2)
                {
                    wholeNum = genorator.Next(min, max);
                    zeroes = genorator.NextDouble();
                    phrase = Convert.ToString(Math.Round((Convert.ToDouble(wholeNum) + zeroes), 2));
                    Console.WriteLine(phrase);
                }
                if (decimals == 3)
                {
                    wholeNum = genorator.Next(min, max);
                    zeroes = genorator.NextDouble();
                    phrase = Convert.ToString(Math.Round((Convert.ToDouble(wholeNum) + zeroes), 3));
                    Console.WriteLine(phrase);
                }
                if (decimals == 4)
                {
                    wholeNum = genorator.Next(min, max);
                    zeroes = genorator.NextDouble();
                    phrase = Convert.ToString(Math.Round((Convert.ToDouble(wholeNum) + zeroes), 4));
                    Console.WriteLine(phrase);
                }
                if (decimals == 5)
                {
                    wholeNum = genorator.Next(min, max);
                    zeroes = genorator.NextDouble();
                    phrase = Convert.ToString(Math.Round((Convert.ToDouble(wholeNum) + zeroes), 5));
                    Console.WriteLine(phrase);
                }
            }

            Console.ReadLine();

        }
    }
}
