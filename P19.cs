using System;
namespace _1
{
    public class P19
    {
        public static void Main()
        {
            int n, a, b,ok=0;
            Console.WriteLine("Introduceti un numar");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti doua cifre pentru a verifica numarul");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

           
           if ((n % 10 == a) || (n % 10 == b))
           {
                ok = 1;
                n /= 10;
           }
           else
               ok = 0;
            
            if (ok != 0)
                Console.WriteLine("Numarul ales poate fi format doar din cifre " + a + " si " + b);
            else
                Console.WriteLine("Nu este posibil");
            


        }
    }
}

