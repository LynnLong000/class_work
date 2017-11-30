using System;

namespace exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00): ");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
                return;
            var time = input.Split(':');
            if (time.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var hour = Convert.ToInt32(time[0]);
            var minute = Convert.ToInt32(time[1]);

            if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                Console.WriteLine("Ok");
            else
                Console.WriteLine("Invalid Time");

            Console.ReadLine();
        }
    }
}
