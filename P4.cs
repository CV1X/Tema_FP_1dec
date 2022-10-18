using System;
namespace _4
{
    public class P4
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("Introduceti un an");
            y = int.Parse(Console.ReadLine());

            if (y % 4 == 0)
                Console.WriteLine("Anul este bisect");
            else
                Console.WriteLine("Anul nu este bisect");


        }
    }
}

