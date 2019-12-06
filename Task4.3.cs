using System;
namespace Задача3
{
    class Program
    {
        static void Main()
        {
            int a, b, c;  //Purvi nachin
            Console.WriteLine("Enter a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            c = int.Parse(Console.ReadLine());
            if(a>b && a>c)
            {
                Console.WriteLine("Biggest number is:{0}", a);
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("Biggest number is:{0}", b);
            }
            else if(c>a && c>b)
            {
                Console.WriteLine("Biggest number is:{0}", c);
            }
            else
            {
                Console.WriteLine("There is no one biggest number");
            }
            /*int[] arr = new int[3]; //Vtori nachin
            int max;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter element {0}:", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            max = arr[0];
            for (int i = 1; i < 3; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max number is:{0}", max);*/

        }
    }
}
