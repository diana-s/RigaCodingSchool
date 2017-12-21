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
            MatematiskoDarbibuAnalizators parser;
            parser = new MatematiskoDarbibuAnalizators();

            //paprasīt lietotājam ievadīt ievadi
            Console.WriteLine("please enter darbību");
            string input = Console.ReadLine();

            int result = parser.ParseMath(input);
            Console.ReadLine();
        
        }
    }
}
