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

            //paprasīt lietotājam ievadīt ievadi
            Console.WriteLine("please enter darbību");
            string input = Console.ReadLine();

            //1+5-4
            //izveidojam mainīgo, kur glabāt rezultatu ar int result
            int result;
            //mēs parbaudam vai tas NAV vienāds ar tukšumu - nomainam == uz != 
            while (input != "")
            {
                //char ir string vai int vieta, ja run air par simbolu
                char symbol = input[0];
                //simboliem neliek divas pēdiņas, bet gan vienu pēdīņu vienmēr
                if (symbol == '+')
                {

                }
                else 
                {
                    int number;
                    //Parse funkcija neņem pretī simbolu, tapēc ar ToString mēs iedodam signālu, pārvērst simbolu par tekstu, un tad viss ok
                    number = Int32.Parse(symbol.ToString());

                }
                
                input = input.Remove(1, input.Length -1);
            }

        }
    }
}
