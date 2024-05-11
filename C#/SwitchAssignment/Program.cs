using System;
namespace SwitchAssignment;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number1: ");
        int number1 = int.Parse(Console.ReadLine());

        System.Console.Write("Enter the number2: ");
        int number2 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Press 1 to add two number\nPress 2 to subtract two number\nPress 3 to multiply two number\nPress 4 to divide two number");
        int operation=int.Parse(Console.ReadLine());

        switch (operation)
        {
            case 1:
                {
                    System.Console.WriteLine(number1+number2);
                    break;
                }
            case 2:
                {
                    System.Console.WriteLine(number1-number2);
                    break;
                }
            case 3:
                {
                    System.Console.WriteLine(number1*number2);
                    break;
                }
            case 4:
                {
                    System.Console.WriteLine(number1/number2);
                    break;
                }

        }
    }
}