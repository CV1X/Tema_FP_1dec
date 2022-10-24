using System;
namespace _1
{
    public class P21
    {
        public static void Main()
        {
            var range = 1024;
            Random rnd = new Random();
            int x = rnd.Next(range);
            

            int ok = 0, k;
            Console.WriteLine("introduceti un numar");
            while (ok != 1)
            {                k = int.Parse(Console.ReadLine());
                if (k == x)
                {
                    Console.WriteLine("Ati ghicit numarul generat");
                    ok = 1;
                }
                    
                else
                    if (x > k)
                        Console.WriteLine("Incercati un numar mai mare");
                    else
                       Console.WriteLine("Incercati un numar mai mic");
                
            }
            
            
        }
    }
}

