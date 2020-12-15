using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, f1 = 0, f2 = 1, f3 = 0;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            if (n == 1)
                Console.WriteLine(f1);
            else
                if (n == 2)
                Console.WriteLine(f2);
            else
            {
                while(n!=2)
                {
                    f3 = f2 + f1;
                    f1 = f2;
                    f2 = f3;
                    n--;
                }
                Console.WriteLine(f3);
            }
        }
    }
}
