using System;

namespace exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between (1-10)... you have 4 trys");
            var answer = new Random().Next(1, 10);
            var guess = 0;
            for (int i = 0; i < 4; i++)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (answer == guess)
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("try again!");
                }
            }
            Console.WriteLine("all your chances are up, you have failed");
        }
    }
}
