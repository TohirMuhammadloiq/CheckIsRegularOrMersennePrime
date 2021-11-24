using System;
using System.Text.RegularExpressions;

namespace oop
{
    class Program
    {
        private static readonly Regex checkInputIsStringOrNumber = new Regex(@"^\d+$");

        static void Main(string[] args)
        {
            var checkInput = true;
            while (checkInput)
            {
                Console.WriteLine("Enter a number: ");
                var number = Console.ReadLine();
                if (number is "quit")
                {
                    break;
                }
                if (!checkInputIsStringOrNumber.IsMatch(number))
                {
                    Console.WriteLine("Invalid input");
                }
                var prime = checkPrime(int.Parse(number));
                if (prime is 2)
                {
                    if (checkMersenne(int.Parse(number)) is 1)
                    {
                        Console.WriteLine("{0} is a Mersenne number", number);
                    }
                    else
                    {
                        Console.WriteLine("{0} is a prime number", number);
                    }
                    // break;
                }
                else
                {
                    Console.WriteLine("{0} is not a prime number", number);
                }
            }
        }

        private static int checkPrime(int number)
        {
            int prime = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    prime++;
                }
            }

            return prime;
        }

        private static int checkMersenne(int number)
        {
            int power = 0;
            for (int i = 1; i < number; i++)
            {
                power = (int)Math.Pow(2, i);
                if ((power - 1) == number || (power + 1) == number)
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}


