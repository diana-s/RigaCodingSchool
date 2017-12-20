using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_calculator
{
    class calculations
    {
        public int AskUserForNumber()
        {
            //izvadīt tekstu, kas paprasa ciparu
            Console.WriteLine("please enter number:");
            //ielasit ciparu no konsoles
            //izveidojam mainīgo, kas glabās tekstu un ierakstam mainīgajā to, ko lietotājs uzrakstīs
            int number;
            string inputText = Console.ReadLine();
            //pārveidot lietotāja tekstu par ciparu
            //int32 ir priekš cipariem
            //Parse saprot tikai ciparus, ja ievada tekstu, tad aplikācija nobrūk
            //lai nenobruktu, var izvēlēties TryParse un ievadīt bool success, kam dot funkciju, parveidot tekstu par ciparu
            //bool nozīmē patiess vai nepatiess
            bool success = Int32.TryParse(inputText, out number);

            // divas == dod funkciju, lai salīdzinātu, jo, ja viss sakrīt, tad ziņojums neparādās
            if(success == false)
            {
                Console.WriteLine("sorry, please write number");
                //lai turpinatu funkciju nevis apstādinātu, un liktu lietotājam vēlreiz ievadīt ciparu, lai viss turpinātos, ir jāievada sekojoši:
                number = this.AskUserForNumber();

            }
            return number;
            
        }
    }
}
