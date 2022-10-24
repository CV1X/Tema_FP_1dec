using System;
namespace _1
{
    public class P10
    {
        public static void Main()
        {
            float n, x = 0;
            Console.WriteLine("Introduceti numarul ");
            n = float.Parse(Console.ReadLine());

            for (float i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    x++;

            }
            if (x == 2)
                Console.WriteLine("Numarul " + n + " este prim");

            else
                Console.WriteLine("Numarul " + n + " nu este prim");
        }

            
    }
}


