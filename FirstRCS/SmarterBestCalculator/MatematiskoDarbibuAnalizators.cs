using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterBestCalculator
{
    class MatematiskoDarbibuAnalizators
    {
        //funkcija, kas saņem lietotāja ievadītu tekstu un saparsē to, veic matemātiskās darbības
        //un atgriež rezultātu
        public int ParseMath(string input)
    
        {
             //1+5  (3 vienibas darbībā, izejošā pozīcija ir 0tā pozīcija (nulles punkts))
            //izveidojam mainīgo, kur glabāt rezultatu ar int result
            int result;
        //counters ir cik ievadītās vienības mēs atļaujam ievadīt. Mēs gribam tikai 3 vienības darbībā.
        int counter = 0;

             //šeit nodefinējam, ka sistēma pārbaudīs katru vienību līdz 3 vienībām un tad beigs parbaudes ciklu un varam dot nakamo komandu piem. aprēķinat rezultatu.
             //counter < input.Length var vadīt tik ciparus, cik vien grib, un sistēma apstrādās visas ievadītās vienības.
            while (counter<input.Length)
            {
                //char ir string vai int vieta, ja run air par simbolu
                char symbol = input[counter];
                //simboliem neliek divas pēdiņas, bet gan vienu pēdīņu vienmēr
                if (symbol == '+')
                {
                    Console.WriteLine("plus");
                }
                else 
                {
                    //saglabā simbolu teksta virknē, lai tam var piekļūt, kad tiek veikta darbība
                    int number;
    //Parse funkcija neņem pretī simbolu, tapēc ar ToString mēs iedodam signālu, pārvērst simbolu par tekstu, un tad viss ok
    number = Int32.Parse(symbol.ToString());
                    Console.WriteLine("number" + number);
                }

counter = counter + 1;
        }
    }
}
