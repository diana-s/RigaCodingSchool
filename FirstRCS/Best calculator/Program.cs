using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //izveido kalkulēšanas objektu 
            //new norāda uz jaunu objektu šajā konkrētajā klasē un attiecas uz visu, kas tiek kodēts zemāk
            calculations calc;
            calc = new calculations();

            //paprasīt lietotajam vērtību
            //string nomaina uz int, jo string norādā mainīgo tekstam, 
            //bet cipariem visur string vietā jānomaina uz int, savādāk, ciparus nevis saskaita, bet savieno
           int firstNumber = calc.AskUserForNumber();

            //jāpaprasa otra vērtība
           int secondNumber = calc.AskUserForNumber();

            //saskaita abas vērtības
            int result = firstNumber + secondNumber;
            Console.WriteLine("Congratulation! Your result is:");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
