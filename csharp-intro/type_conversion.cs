using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversation
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 1;
            int i = a;
            Console.WriteLine(i);
            int b = 1;
            byte j = (byte)b;
            Console.WriteLine(j);

            try
            {
                var number = "1234";
                byte c = Convert.ToByte(number);
                Console.WriteLine(c);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            try
            {
                string str = "true";
                bool c = Convert.ToBoolean(str);
                Console.WriteLine(c);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
        }
    }
}
