using System;

namespace exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter names seperate by commas and press enter when your done: ");
            var input = Console.ReadLine();

            var names = input.Split(',');

            if (names.Length == 1)
            {
                Console.WriteLine(names[0] + " like your photo");
                Console.ReadLine();
            }
            else if(names.Length == 2)
            {
                Console.WriteLine(names[0]+ " "+ names[1] + " like your photo");
                Console.ReadLine();
            }
            else if(names.Length > 2)
            {
                Console.WriteLine(names[0] + " " + names[1] + " " + (names.Length - 2) + " others like your photo");
                Console.ReadLine();
            }
        }
    }
}
