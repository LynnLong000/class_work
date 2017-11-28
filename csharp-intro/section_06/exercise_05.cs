using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
 *  If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
 *  otherwise, display the 3 smallest numbers in the list.
 *
 * */

namespace exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Five or more numbers seprates with comma: ");
            var input = Console.ReadLine();
            string[] elements = input.Split(',');
            var numbers = new List<int> { } ;
            for(var i = 0; i < elements.Length; i++)
            {
                numbers.Add(Convert.ToInt32(elements[i]));
            }

            if(numbers.Count < 5)
            {
                Console.WriteLine("Invalid List. Please retry");
            }
            numbers.Sort();

            Console.WriteLine("three smallest numbers are {0}, {1}, {2}.",numbers[0],numbers[1],numbers[2]);
        }
    }
}
