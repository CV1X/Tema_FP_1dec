using System;
namespace _1
{
    public class P9
    {
        public static void Main()
        {
            float n;
            Console.WriteLine("Introduceti numarul");
            n = float.Parse(Console.ReadLine());

            for(float i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    
                    Console.Write(" Divizorii sunt  " + i);
                }
                
            }
        }
    }
}

