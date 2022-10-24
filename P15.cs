using System;
using System.Runtime.Intrinsics.X86;

namespace _1
{
    public class P15
    {
        public static void Main()
        {
            int a, b, c,aux ;
            Console.WriteLine("Introduceti numerele");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }

            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }

            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }

            Console.WriteLine("Numerele in ordine crescatoare sunt " + a + " " + b + " " + c);

        }
    }
}

