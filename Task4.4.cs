﻿using System;
namespace Задача4
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            for(int i=1;i<=100;i++)
            {
                if(i%2==0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of the even numbers is:{0}", sum);
        }
    }
}
