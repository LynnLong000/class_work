using System;

namespace @enum
{
    public enum shippingMethod
    {
        RegularAirMail = 1,
        RegidteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = shippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((shippingMethod)methodId);
            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (shippingMethod)Enum.Parse(typeof(shippingMethod), methodName);
        }
    }
}
