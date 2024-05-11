using System;
namespace ForAssignment;
class Program 
{
    public static void Main(string[] args)
    {
        int total=0;
        System.Console.WriteLine("Enter the 10 numbers");
        for(int i=0;i<10;i++)
        {
            int numbers=int.Parse(Console.ReadLine());
            total+=numbers;
        }

        Console.WriteLine("The Sum of the total is: "+total);
        Console.WriteLine("The Average is: "+(total/10));
    }
}