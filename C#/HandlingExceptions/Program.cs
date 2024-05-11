using System;
namespace SwitchAssignment;
class Program
{
    public static void Main(string[] args)
    {
        try
        {
            System.Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());
            System.Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine(number1 / number2);
        }
        catch (FormatException)
        {
            System.Console.WriteLine("Input was not in correct form");
            //throw;
        }
        
    }
}