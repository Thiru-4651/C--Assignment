using System;
namespace Arrayassignment;
class Program 
{
    public static void Main(string[] args)
    {
        char istrue='Y';

        while(istrue=='Y')
        {
            System.Console.WriteLine("Which city is capital of India?\n\n1.Chennai\n2.Delhi\n3.Mumbai\n4.Kolkata\n");
            System.Console.Write("Enter the choice(Y/N): ");
            istrue=char.Parse(Console.ReadLine());
        }
    }
}