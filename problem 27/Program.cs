﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;

            Console.Write("\n\n");
            Console.Write("Find the sum of all integer between 100 and 200,:\n");
            Console.Write("-----------------------------------------------------------------------------");
            Console.Write("\n\n");

         
            for (i = 101; i < 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.Write("{0}  ", i);
                    sum += i;
                }
            }
            Console.Write("\n\nThe sum : {0} \n", sum);
            Console.ReadLine();
        }
    }
}
