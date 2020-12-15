using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            float n, i, nr, s = 0;
            Console.Write("n=");
            n = float.Parse(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                Console.WriteLine("nr=");
                nr = float.Parse(Console.ReadLine());
                s = s + 1 / nr;
            }
            Console.WriteLine("Suma inverselor numerelor date este {0}", s);
        }
    }
}
