using System;
namespace _6
{
    public class P6
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("introduceti laturile");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if ((a < b + c) && (b < a + c) && (c < a + b) && (a > 0) && (b > 0) && (c > 0))
            {
                Console.WriteLine(" Numerele pot forma triunghi");
                if ((a == b) && (b == c))
                    Console.WriteLine("Triunghiul este echilateral");
                else if ((a == b) || (b == c))
                    Console.WriteLine("Triunghi isoscel");
                else
                    Console.WriteLine("Triunghi oarecare");
            }
            else
                Console.WriteLine("Laturile nu pot forma triunghi");
        }
    }
}

