using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write any number from 1 till 100");
            string start = " ";
            start = Console.ReadLine();

            int StartNumber = Int32.Parse(start);
           
            
            if (StartNumber > 100)
            {
                Console.WriteLine("Please start again");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("All numbers which divides with 3 & 5 will show you Fizz Buzz");
                Console.WriteLine("Now start play FizzBuzz game starting from your number :)");
                Console.WriteLine("Press Enter to get further");
                for (int i = StartNumber; StartNumber <= 100 && i<= 100; i++)

                {


                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.ReadLine();     
            }
          







        }
    }
}
