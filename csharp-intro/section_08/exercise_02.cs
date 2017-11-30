using System;
using System.Collections.Generic;

namespace exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("enter a few numbers seprated by '-' ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    return;
                var hold = input.Split('-');

                var numbers = new List<int>();
                foreach (var number in hold)
                    numbers.Add(Convert.ToInt32(number));

                var isduplicate = false;

                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] == (numbers[i-1]))
                    {
                        isduplicate = false;
                    }
                }


                if (isduplicate)
                {
                    Console.WriteLine("duplicate");
                }
                else
                {
                    Console.WriteLine("Not duplicate");
                }
                Console.ReadLine();
            }
        }
    }