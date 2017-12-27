using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsole
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter First number");
            string a = Console.ReadLine();
            Console.WriteLine("please enter Second number");
            string b = Console.ReadLine();
            

            int c = Int32.Parse(a) + Int32.Parse(b);
            Console.WriteLine("Sum of {0} + {1} is: {2}", a, b, c);
            Console.ReadLine();

            int d = Int32.Parse(a) - Int32.Parse(b);
            Console.WriteLine("Subtraction of {0} - {1} is: {2}", a, b, d);
            Console.ReadLine();

            int e = Int32.Parse(a) * Int32.Parse(b);
            Console.WriteLine("Multiplication of {0} * {1} is: {2}", a, b, e);
            Console.ReadLine();
            
            int g = Int32.Parse(b) / Int32.Parse(a);
            Console.WriteLine("Dividion of {0} / {1} is: {2}", b, a, g);
            Console.ReadLine();


        }
    }
}

  