using System;
public class P7
{
    public static void swap(ref int num1,ref int num2)
    {
        int newnum;

        newnum = num1;
        num1 = num2;
        num2 = newnum;
    }
    public static void Main()
    {
        int n1, n2;
        Console.Write("Introdu un numar: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Introdu alt numar: ");
        n2 = int.Parse(Console.ReadLine());

        swap(ref n1,ref n2);
        Console.WriteLine("Primul numar va fi : {0} , iar al doilea va fi : {1}", n1, n2);
    }
}
