using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, nr, k = 0;
            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                Console.WriteLine("nr=");
                nr = int.Parse(Console.ReadLine());
                if (nr == i)
                    k++;
            }
            Console.WriteLine("Exista {0} numere care sunt egale cu pozitia pe care o ocupa in secventa data", k);
        }
    }
}
