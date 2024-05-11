using System;
namespace Arrayassignment;
class Program 
{
    public static void Main(string[] args)
    {
        int[] array=new int[10];
        int[] oddarray=new int[5];
        int[] evenarray=new int[5];
        int increament1=0,increament2=0;
        System.Console.WriteLine("Enter the Numbers");
        for(int i=0;i<10;i++)
        {
            array[i]=int.Parse(Console.ReadLine());
            if(array[i]%2==0)
            {
                evenarray[increament1]=array[i];
                increament1++;
            }
            else
            {
                oddarray[increament2]=array[i];
                increament2++;
            }
        }
        System.Console.Write("Odd Numbers: ");
        for(int i=0;i<5;i++)
        {
            Console.Write(oddarray[i]+" ");
        }
        System.Console.WriteLine();
        System.Console.Write("Even Numbers: ");
        for(int i=0;i<5;i++)
        {
            Console.Write(evenarray[i]+" ");
        }

    
    }
}