using System;
namespace Задача1
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Enter n:");
            n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
