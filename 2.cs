using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, nr, poz = 0, neg = 0, zero = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                Console.Write("nr=");
                nr = int.Parse(Console.ReadLine());
                if (nr == 0)
                    zero++;
                else
                    if (nr < 0)
                    neg++;
                else
                    poz++;
            }
            Console.WriteLine("In secventa data exista {0} numere negative,{1} numere pozitive si {2} de zero", neg, poz, zero);
        }
    }
}
