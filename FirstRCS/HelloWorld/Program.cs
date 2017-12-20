using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            personal_greeting greet;
            greet = new personal_greeting();
            greet.HelloText = "Hell world!";
            greet.SayHello();
            
            personal_greeting greetnew;
            greetnew = new personal_greeting();
            greetnew.HelloText = "Aloha";
            greetnew.SayHello();

            Console.ReadLine();
        }
    }
}
