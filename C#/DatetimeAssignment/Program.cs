using System;
namespace StringAssignment;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date=DateTime.Now;
        System.Console.WriteLine("current month of the day: "+date.Month);
        int day=date.Day;
        System.Console.WriteLine("Previous 3 day from current date");
        for(int i=1;i<=3;i++)
        {
            System.Console.WriteLine(day-i);
        }
        System.Console.WriteLine("12 hours’ time of now followed by am , pm: "+DateTime.Now);
    }
}