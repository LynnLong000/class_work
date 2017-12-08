using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            int start = 0;
            int max = 5;

            for(int i = start; i <= max; i++)
            {
                stack.Push(i);
            }

            for (int i = start; i <= max; i++)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.ReadLine();
        }
    }
}
