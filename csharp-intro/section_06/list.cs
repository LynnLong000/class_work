using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> {1,2,3,4};
            numberd.add(1);
            numbers.addRange(new int[3]{5,6,7});

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));
            Console.WriteLine("Count: " + numbers.count);

            for (var i = 0; i < numbers.count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(number[i])
            }

            foreach (var number in numbers)
                Console.WriteLine(number);

            numbers.clear();
            Console.WriteLine("Count: " + numbers.count);
        }
    }
}