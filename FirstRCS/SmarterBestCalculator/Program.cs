﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterBestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //izveido kalkulatora objektu
            Class1 mathcycle;
            mathcycle = new Class1();

            while (true)
            {
                //paprasīt lietotājam ievadīt ievadi
                Console.WriteLine("please enter operation");
                string input = Console.ReadLine();

                int result1 = mathcycle.Cycle1(input);




                Console.WriteLine("your result is = " + result1);
               
            }
            


        }
    }
}
