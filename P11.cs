using System;
namespace _1
{
    public class P11
    {
        public static void Main()
        {
            int n, k=0, x=0;
            Console.WriteLine("introduceti numerele");
            n = int.Parse(Console.ReadLine());
            Console.Write("numarul invers este : ");
            while (n != 0)
            {
                k = n % 10;
                n = n / 10;
                Console.Write("" + k);

            }
            
        }
    }
}

// 123 --- 321
// 3
// 2
// 1