using System;

namespace exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers separated by commoa: ");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);
            for (var i = 0; i < numbers.Length; i++)
            {
                if (Convert.ToInt32(numbers[i]) > max)
                {
                    max = Convert.ToInt32(numbers[i]);
                }
            }
            Console.WriteLine("Max number is " + max);
        }
    }
}
