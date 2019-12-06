using System;
namespace Задача6
{
    class Program
    {
        static int findFactorial(int n)
        {
            int factorial = 1;
            for(int i=1;i<=n;i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        static void Main()
        {
            int n, k, fac1, fac2;
            double result = 0.0;
            Console.WriteLine("Enter n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter k:");
            k = int.Parse(Console.ReadLine());
            fac1 = findFactorial(n);
            fac2 = findFactorial(k);
            Console.WriteLine("Factorial of number {0} is:{1}", n, fac1);
            Console.WriteLine("Factorial of number {0} is:{1}", k, fac2);
            result = (double)fac1 / (double)fac2;
            result = Math.Round(result, 2);
            Console.WriteLine("Result is:{0}", result);
        }
    }
}
