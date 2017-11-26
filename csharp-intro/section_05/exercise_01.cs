using System;

namespace execise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(var i = 1; i<100; i++)
            {
                if((i%3) == 0)
                {
                    Console.WriteLine("this number is divisible by three" + i);
                    count++;
                }
                Console.WriteLine(i);
            }
        }
    }
}