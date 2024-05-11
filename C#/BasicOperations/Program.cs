using System;
namespace BasicOperations;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the First Number:");
        float a=float.Parse(Console.ReadLine());
        System.Console.Write("Enter the Second Number:");
        float b=float.Parse(Console.ReadLine());

        Console.WriteLine("Addition of two numbers = "+(a+b));
        Console.WriteLine("Substraction of two numbers = "+(a-b));
        Console.WriteLine("Multiplication of two numbers = "+(a*b));
        Console.WriteLine("Division of two numbers = "+(a/b));
        Console.WriteLine("Modulus of two numbers = "+(a%b));
    }
}