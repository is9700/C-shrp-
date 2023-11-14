using System;

namespace Delegate
{
    class MainClass
    {
        public delegate int Calc(int a, int b);

        public static int Summe(int a, int b)
        {
            return a + b;
        }

        public static int Produkt(int x, int y)
        {
            return x * y;
        }

        public static void Main(string[] args)
        {
            Calc c = new Calc(Summe);
            
            Console.WriteLine(c(100, 10));
            c = Produkt;
            Console.WriteLine(c(200, 10));

            c = delegate (int a, int b)
            {
                return a - b;
            };

            Console.WriteLine(c(200, 100));

            c = (a, b) => a / b;

            Console.WriteLine(c(200, 100));
        }
    }
}
