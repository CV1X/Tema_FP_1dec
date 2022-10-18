using System;
namespace _2
{
    class P2
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double d , x1, x2;
            Console.WriteLine("Introduceti numerele a , b si c");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a != 0)
            {
               
                d = Math.Sqrt((b * b) - (4 * a * c));

                if (d < 0)
                    Console.WriteLine("Avem radacini complexe");
                else
                {
                    x1 = (-b + d) / 2 * a;
                    x2 = (-b - d) / 2 * a;
                    Console.WriteLine("Solutiile sunt : {0} si {1}", x1, x2);
                }

            }
            else
                    if (b != 0)
                {
                    x1 = -c / b;
                    Console.WriteLine("Solutia este = {0}", x1);
                }
                else
                    if (c == 0)
                        Console.WriteLine("Solutie nedeterminata");
                    else
                        Console.WriteLine("Solutie Imposibila");


        }
    }
}