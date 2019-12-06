using System;
namespace Задача5
{
    class Program
    {
        static void Main()
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int number;
            foreach(string str in months)
            {
                Console.WriteLine("{0}", str);
            }
            Console.WriteLine();
            Console.WriteLine("Enter number between 1 and 12:");
            number = int.Parse(Console.ReadLine());
            for(int i=0;i<months.Length;i++)
            {
                if(number==(i+1))
                {
                    Console.WriteLine("Month is:{0}", months[i]);
                }
            }
        }
    }
}
