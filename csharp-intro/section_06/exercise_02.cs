using System;

namespace exercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name please: ");
            var input = Console.ReadLine();

            var name = new char[input.Length];
            for (var i = 0; i < input.Length; i++)
            {
                name[i] = input[i];
            }

            Array.Reverse(name);
            var reverseName =  new String(name);
            Console.WriteLine(" name: " + input);
            Console.WriteLine("Reversed name: " + reverseName);
            Console.ReadLine();
        }
    }
}
