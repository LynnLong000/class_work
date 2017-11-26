using System;

namespace exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for(int i = 1; i < number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("factorial of {0} is {1}", number, factorial);
        }
    }
}
