﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_Statement_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ineligible:
                Console.WriteLine("You are not eligible to vote!");

            Console.WriteLine("Enter your age: \n");

            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("Your are eligible to vote!");
            }
        }
    }
}
