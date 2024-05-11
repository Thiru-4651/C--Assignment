using System;
namespace StringAssignment;
class Program
{
    public static void Main(string[] args)
    {
        string input = "Syncfusion";

        System.Console.WriteLine("=>Odd Numbers of the string");
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 != 0)
            {
                System.Console.Write(input[i] + " ");
            }
        }

        System.Console.WriteLine();
        System.Console.WriteLine("=>Replace the character n with capital N");
        string temp = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'n')
            {
                temp = "SyNcfusion";
            }
        }

        System.Console.WriteLine(temp);

        System.Console.WriteLine("=>Display the above string in reverse");

        for (int i = input.Length - 1; i >= 0; i--)
        {

            System.Console.Write(input[i]);
        }

        System.Console.WriteLine();
        System.Console.WriteLine("=>Calculate the length of above string");

        int length = 0;
        foreach (int x in input)
        {
            length++;
        }

        System.Console.WriteLine(length);

        System.Console.WriteLine("Enter the First string");
        string string1 = Console.ReadLine();

        System.Console.WriteLine("Enter the Second string");
        string string2 = Console.ReadLine();

        if (string1.Length.Equals(string2.Length))
        {
            for (int i = 0; i < string1.Length;i++)
            {
                if(i<(string1.Length)/2)
                {
                    System.Console.Write(string1[i]);
                }
                else
                {
                    System.Console.Write(string2[i]);
                }
            }
        }
        else
        {
            System.Console.WriteLine("String length was not same");
        }

        string cities="Chennai,Trichy,Mumbai";
        string[] values=cities.Split(',');

        for(int i=0;i<values.Length;i++)
        {
            System.Console.WriteLine(values[i]);
        }
    }
}