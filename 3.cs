using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, s = 0, p = 1;
            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                s = s + i;
                p = p * i;
            }
            Console.Write("Suma numerelor este {0},iar produsul este {1}", s, p);
        }
    }
}
