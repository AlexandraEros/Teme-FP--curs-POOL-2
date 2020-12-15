using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, nr, maxim = -9999999, minim = 999999999;
            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                Console.WriteLine("nr=");
                nr = int.Parse(Console.ReadLine());
                if (nr > maxim)
                    maxim = nr;
                if (nr < minim)
                    minim = nr;
            }
            Console.WriteLine("Maximul din secventa data este {0},iar minimul este {1}", maxim, minim);
        }
    }
}
