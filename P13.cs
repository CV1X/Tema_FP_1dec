using System;
namespace _1
{
    public class P13
    {
        public static void Main()
        {
            int y1, y2, x=0;
            Console.WriteLine("Introduceti un interval");
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());

            for(int i=y1; i<=y2; i++)
            {
                if ((i%400==0) || (i % 4 == 0) && (i%100 !=0))
                    x++;
            }
            Console.WriteLine("Sunt " + x + " ani bisecti");
        }
    }
}

