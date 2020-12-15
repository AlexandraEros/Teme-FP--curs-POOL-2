using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, poz = -1, i, nr;
            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                Console.WriteLine("nr=");
                nr = int.Parse(Console.ReadLine());
                if (nr == a)
                    poz = i;
            }
            if (poz != -1)
                Console.WriteLine("Numarul a se afla pe pozitia {0}", poz);
            else
                Console.WriteLine("Numarul a nu se afla in secventa de numere data");

        }
    }
}
