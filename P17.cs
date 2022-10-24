using System;
namespace _1
{
    public class P17
    {
        public static void Main()
        {
            long divizor=0 ,multiplu;
            Console.WriteLine("Introduceti numerele");
            long x = Int32.Parse(Console.ReadLine());
            long y = Int32.Parse(Console.ReadLine());

            if (x > y)
            {
                if (x % y == 0)
                    divizor = y;
                else
                    divizor = x % y;

            }
            else
            {
                if (y % x == 0)
                    divizor = x;
                else
                    divizor = y % x;
            }

            multiplu = (x * y ) / divizor;


            Console.WriteLine("CMMDC este " + divizor);
            Console.WriteLine("CMMMC este " + multiplu);



        }
    }
}

