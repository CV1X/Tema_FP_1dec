using System;
public class P8
{
    
    public static void Main()
    {
        int n1, n2;
        Console.Write("Introdu un numar: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Introdu alt numar: ");
        n2 = int.Parse(Console.ReadLine());

        n1 = n1 + n2;
        n2 = n1 - n2;
        n1 = n1 - n2;

        
        Console.WriteLine("Primul numar va fi : {0} , iar al doilea va fi : {1}", n1, n2);
    }
}
