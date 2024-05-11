using System;
namespace LargestNum;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number:");
        int number1=int.Parse(Console.ReadLine());

        Console.Write("Enter the second number:");
        int number2=int.Parse(Console.ReadLine());

        Console.Write("Enter the third number:");
        int number3=int.Parse(Console.ReadLine());

        if(number1>number2 && number1>number3)
        {
            Console.WriteLine("First Number is big");
        }
        else if(number2>number1 && number2>number3)
        {
            Console.WriteLine("Second Number is big");
        }
        else
        {
             Console.WriteLine(" Third Number is big");
        }
    }
}