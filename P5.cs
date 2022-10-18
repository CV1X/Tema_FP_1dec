using System;
namespace _5
{
    public class P5
    {
        static void Main(string[] args)
        {
            int x, k , nr=0;
            Console.WriteLine("introduceti un numar si cifra pe care doriti sa o aflati");
            x = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            while (x != 0 && (k-1) != 0)
            {
                x = x / 10;
                k = k - 1;
                nr = x % 10;
            }
            Console.WriteLine("Cifra este : {0}", nr);

        }
            
    }
}

