using System;
namespace _1
{
    public class P18
    {
        public static void Main()
        {
            int d = 2, p, n;
            Console.WriteLine("Introduceti numarul");
            n = int.Parse(Console.ReadLine());

            while (n != 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    n /= d;
                    p++;

                }

                if (p != 0)
                    Console.WriteLine(d + " ^ " + p);
                d++;
                p = 0;
            }
        }
    }
}

