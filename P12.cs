using System;
namespace _1
{
    public class P12
    {
        public static void Main()
        {
            float a, b, n,k=0,x=0;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            n = float.Parse(Console.ReadLine());

            for (k = a; k <= b; k++)
            {
                if (k % n == 0)
                    x++;
                    
            }
            Console.Write("Sunt " + x + " numere");
        }
    }
}

