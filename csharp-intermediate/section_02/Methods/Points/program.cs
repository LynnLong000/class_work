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
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at({0},{1})", point.x, point.y);

                point.Move(100,200);
                Console.WriteLine("Point is at({0},{1})", point.x, point.y);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
