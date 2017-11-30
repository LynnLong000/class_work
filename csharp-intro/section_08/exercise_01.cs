using System;
using System.Collections.Generic;


namespace exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a few numbers seprated by '-' ");
            var input = Console.ReadLine();
            var hold =  input.Split('-');

            var numbers = new List<int>();
            foreach (var number in hold)
                numbers.Add(Convert.ToInt32(number));

            var isConsective = true;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != (numbers[0] + i ))
                {
                    isConsective = false;
                }
            }


            if(isConsective)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
            Console.ReadLine();
        }
    }
}
