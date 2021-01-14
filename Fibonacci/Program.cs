using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter max value");
            string maxValString = Console.ReadLine();
            int maxVal = Int32.Parse(maxValString);
            int sum = 0;
            int sumEven = 0;
            int sumOdd = 0;
            int number1 = 0;
            int number2 = 1;
            for (int number3 = 1; number3 < maxVal;)
            {
                number3 = number1 + number2;
                number1 = number2;
                number2 = number3;
                sum += number3;
                if (number3 % 2 == 0)
                {
                    sumEven += number3;
                }
                else
                {
                    sumOdd += number3;
                }
                Console.WriteLine(number3);
            }
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("sum even: " + sumEven);
            Console.WriteLine("sum odd: " + sumOdd);
        }
    }
}
