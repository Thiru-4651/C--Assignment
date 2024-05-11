using System;
namespace Arrayassignment;
class Program 
{
    public static void Main(string[] args)
    {
        int[] array=new int[5];
        System.Console.WriteLine("Enter the Numbers");
        for(int i=0;i<5;i++)
        {
            array[i]=int.Parse(Console.ReadLine());
        }

        for(int i=0;i<5;i++)
        {
            for(int j=i+1;j<5;j++)
            {
                if(array[i]>array[j])
            {
                int temp=array[j];
                array[j]=array[i];
                array[i]=temp;
            }

            }
            
            //array[i]=int.Parse(Console.ReadLine());
        }

        for(int i=0;i<5;i++)
        {
            System.Console.Write(array[i]+" ");
        }
        
    }
}