using System;

namespace exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 0;
            while (true)
            {
                Console.WriteLine("Enter Number until done than enter ok");
                var input = Console.ReadLine();

                if( input.ToLower() == "ok")
                {
                    Console.WriteLine("Sum is " + answer);
                }

                answer = answer + Convert.ToInt32(input);
            }
        }
    }
}