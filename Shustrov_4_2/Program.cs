using System;

namespace Shustrov_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());

            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());

            double W = 1;
            int data = 1;

            for (int i = 2; i <= n; i++)
            {
                W += Math.Pow(Math.Cos(x), data) / (Math.Sqrt(Math.Pow(a,data) + Math.Sin(a + i % 2 * Math.PI / 2)));
                data += 2;
            }
            Console.WriteLine("Result="+W);
        }
    }
}
