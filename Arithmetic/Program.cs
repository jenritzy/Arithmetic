﻿using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 8;
        int b = 4;
        Console.WriteLine("Addition:\t" + (a + b));
        Console.WriteLine("Subtraction:\t" + (a - b));
        Console.WriteLine("Multiplication:\t" + (a * b)); 
        Console.WriteLine("Division:\t" + (a / b));
        Console.WriteLine("Modulus:\t" + (a % b));
        Console.WriteLine("\nPostfix:\t" + (a++));
        Console.WriteLine("Postfix Result....:\t" + a);
        Console.WriteLine("\nPrefix:\t" + (++b));
        Console.WriteLine("Prefix Result....:\t" + b);
        Console.ReadKey();
    }
}