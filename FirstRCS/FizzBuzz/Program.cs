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
            //lietotājam ievada savu ciparu
            string start = " ";
            start = Console.ReadLine();
            //lai šo ciparu spētu sistēma nolasīt kā ciparu nevis tekstu, izveidoju jaunu mainīgo
            //kas ir vienāds ar šo pašu ievadīto tekstu, bet jau pārveidots par ciparu ar Int32.Parse 
            int StartNumber = Int32.Parse(start);
           
            //es gribu, lai spēle darbotos tikai tajā gadījumā, ja lietotaja ievadītais cipars ir mazāks par 100
            //tāpēc, ja cipars ir lielāks, sistēma izmet aicinajumu sākt spēli no sākuma un izmet lietotāju no sist.
            if (StartNumber > 100)
            {
                Console.WriteLine("Please start again");
                Console.ReadLine();
            }
            //ja ievadītais cipars ir mazāks par 100, tad parādās tālākās norādes
            else
            {
                Console.WriteLine("All numbers which divides with 3 & 5 will show you Fizz Buzz");
                Console.WriteLine("Now start play FizzBuzz game starting from your number :)");
                Console.WriteLine("Press Enter to get further");
                Console.ReadLine();

                //norādu, ka i = ievadīto lietotāja tekstu, kurš pārveidots par ciparu
                //un ja es norādu, ka i <= 100, tad sistēma norāda visus ciparus spēlē līdz 100
                //P.s. ja es ievadītu tikai StartNUmber <= 100, sistēma neapstatos pie 100, bet turpinātu rādīt paziņojumus
                for (int i = StartNumber+1; i<= 100; i++)

                {

                    //liekam % zīmīti, nevis /, jo kods % :
                    //Iegūst moduli, t. i., izdala pirmo mainīgo ar otro līdz apaļam rezultātam, 
                    //un atgriež to, kas paliek pāri (parādīšu)

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
