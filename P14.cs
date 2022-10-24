using System;
namespace _1
{
    public class P14
    {
        public static void Main()
        {
            int n, k, y=0,copie;
            Console.WriteLine("introduceti un numar");
            n = int.Parse(Console.ReadLine());
            copie = n;
            while (n != 0)
            {
                k = n % 10;
                n = n / 10;
                y = y * 10 + k;
                
            }

            if (y == copie)
                Console.WriteLine("Numarul " + copie + " este palindrom");
            else
                Console.WriteLine("numarul " + copie + " nu este palindrom");
        }
    }
}
