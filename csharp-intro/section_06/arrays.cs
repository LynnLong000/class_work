using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {3,7,9,2,14,6};

            Console.WriteLine("Length: " + numbers.Length);

            var index = Array.IndexOf(numbers,9);
            Console.WriteLine ("Index of 9: " + index);

            Array.Clear (numbers,0,2);
            Console.WriteLine("Efect of clear ")
            foreach (var n in numbers)
                Console.WriteLine(n);


            int[] another = new int[3]
            Array.Copy (numbers,0,2);
            Console.WriteLine("Efect of copy ")
            foreach (var n in numbers)
                Console.WriteLine(n);


           array.Sort(numbers);
            Console.WriteLine("Efect of sort ")
            foreach (var n in numbers)
                Console.WriteLine(n);

           array.Reverse(numbers);
            Console.WriteLine("Efect of reverse ")
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}