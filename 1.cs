using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, p = 0, nr;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                Console.Write("nr= ");
                nr = int.Parse(Console.ReadLine());
                if (nr % 2 == 0)
                    p++;
            }
            Console.Write("Exista {0} numere pare in secventa data", p);
        }
    }
}
