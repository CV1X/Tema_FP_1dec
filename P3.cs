using System;
namespace _3
{
    public class P3
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("introduceti numerele");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            

            if (n % k != 0)
                Console.WriteLine("Numerele nu se divid");
            else
                Console.WriteLine("numerele se divid");
        }
    }
}

