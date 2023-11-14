using System;

namespace ArrayList
{
    class MainClass
    {

        public static void Main(string[] args)
        {

            /*
            ArrayList liste = new ArrayList();

            for (int i = 1; i <= 100; i++)
            {
                liste.Add(1.0 * i);
                Console.WriteLine("Capacity = {0}  Count = {1}", liste.Capacity, liste.Count);
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("{0:F}", liste.Get(i));
            }
            */

           

            ArrayList<double> a = new ArrayList<double>();
            ArrayList<double> b = new ArrayList<double>();



            for (int i=0; i < 10; i++)
            {
                a.Add(1.0 * i);
                b[i] = (2.0 * i);
            }

            ArrayList<double> c = a + b;

            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0:F}", c[i]);
            }

            
            Console.ReadLine();
        }
    }
}
