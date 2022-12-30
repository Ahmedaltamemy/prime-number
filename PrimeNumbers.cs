using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;



namespace Dcoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int j, i, fac, startNum, endNum;

            Console.WriteLine("\n\n");
            Console.WriteLine("Find the prime numbers within a range of numbers:");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("Input starting number of range: ");
            startNum = int.Parse(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            endNum = int.Parse(Console.ReadLine());
            Console.WriteLine("The prime numbers between {0} and {1} are : ", startNum, endNum);

            for (j = startNum; j <= endNum; j++)
            {
                fac = 0;

                for (i = 2; i <= j / 2; i++)
                {
                    if (j % i == 0)
                    {
                        fac++;
                        break;
                    }
                }

                if (fac == 0 && j != 1)
                    Console.Write("   {0}     is a prime number \n", j);

            }
            Console.ReadKey();
        }
    }
}