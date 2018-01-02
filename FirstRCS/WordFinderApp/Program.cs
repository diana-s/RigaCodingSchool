using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WordFinderApp
{
    class Program

    {
        static void Main(string[] args)
        {

            // paprasīt lietotājam ievadīt tekstu
            Console.WriteLine("Please enter not more than 8 letters from your keypad");
            // iegūt no ievadītā teksta visus unikālos burtus
            string InputLetters = Console.ReadLine();

            // izveidot mainīgo, kurā glabāsim tekstu, kas saturēs unikālos burtus
            char[] array = InputLetters.ToCharArray();

            // Loop through array.
            for (int i = 0; i < array.Length; i++)
            {
                // Get character from array.
                var UniqueLetterSplit = array[i];
            }
            
            var dictionaryFilePath = @"C:\Users\Diana\CODES\RigaCodingSchool\wordFinder.txt";
            var allWordsInFile = File.ReadAllLines(dictionaryFilePath);

            
            


            // ciklā iet cauri lietotāja ievadītajam tekstam pa vienam burtam
            // ja šis burts neatrodas mūsu izveidotajā unikālo burtu teksta mainīgajā, tad pievienot šo burtu
            //šim teksta mainīgajam
            // kad viss teksts apskatīts, atgriezt rezultāta teksta mainīgo ar unikālajiem burtiem
            // nolasīt visus vārdus no faila, ierakstot tos sarakstā, kur katrs ieraksts ir viens vārds
            // iet cauri sarakstam pa vienam vārdam
            // iet cauri šobrīdējam vārdam no faila pa vienam simbolam
            // pārbaudīt, vai šis simbols atrodas mūsu unikālo burtu tekstā
            // ja simbols neatrodas starp unikālajiem simboliem, tad pārstāt iet cauri šim vārdam pa simboliem

            // iet cauri unikālajiem simboliem pa vienam simbolam
            // pārbaudīt, vai šis simbols atrodas mūsu vārda no faila tekstā
            // ja simbols neatrodas vārdā no faila, tad pārstāt iet cauri šim vārdam
            // ja visi simboli no vārda atrodas unikālo simbolu virknē un visi unikālie simboli atrodas vārdā,izvadīt to uz ekrāna





            Console.ReadLine();



        }






    }
}