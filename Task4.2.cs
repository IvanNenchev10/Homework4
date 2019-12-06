using System;
namespace Задача2
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Enter number of elements:");
            n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                if(!(i%3==0 && i%7==0))
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
