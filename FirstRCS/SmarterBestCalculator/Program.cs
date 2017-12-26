using System;
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

             Class2 matchcycle2;
            matchcycle2 = new Class2();

            //paprasīt lietotājam ievadīt ievadi
            Console.WriteLine("please enter operation");
            string input = Console.ReadLine();

            int result1 = mathcycle.Cycle1(input);
            int result2 = matchcycle2.Cycle2(input);

            if (result1 == mathcycle.Cycle1(input))
            {
                Console.WriteLine("your result is = " + result1);
                Console.ReadLine();
            }
            if(result2 == matchcycle2.Cycle2(input))
               {
                    Console.WriteLine("your result is = " + result2);
                    Console.ReadLine();
                }

                    
                 
        }
    }
}
