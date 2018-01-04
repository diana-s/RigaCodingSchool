using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterBestCalculator
{
    class Class1
    {
        public int Cycle1(string input)
       {
           string FirstEnteredNumber = "";
           char EnteredOperation = ' ';
            bool OperationFound = false;
            
            for(int counter = 0;  counter < input.Length; counter++)
            {
                char symbol = input[counter];
                if (symbol == '+' || symbol == '-')
                {
                    EnteredOperation = symbol;
                    OperationFound = true;
                }
                else
                {
                    if(OperationFound == false)
                    {
                        FirstEnteredNumber = FirstEnteredNumber + symbol;

                    }
                    
                }
                
                if (OperationFound == true)
                {
                    if (EnteredOperation == '+')
                    {
                        //Int32.Parse(SecondEnteredNumber) nomainijām uz this.Cycle1(input.Substring(counter+1), 
                        //lai varētu ierakstīt vairākas saskaitīšanas vienā rindā un sistēma saprastu, ka ir vairāki '+',
                        //nevis visi parējie simboli pēc pirmā '+' ir otrs ievadītais cipars (kā būtu, ja atstātu pirmo ievadi ar Int32...

                        //Tā kā gribam, lai sistēma saprot, ka sekos vairākas saskaitīšanas un vairāki atsevišķi cipari, tad
                        //liekam + this.Cycle1: kas nozīmē šakā konkrētajā ciklā
                        //input:ievadītais "cipars" vai 'operācija'
                        //Substring(counter+1): pieskaita konrēto ievadi, kas sākas no countera un iet tālāk uz priekšu (mūžīgi)
                     
                        int result = Int32.Parse(FirstEnteredNumber) + this.Cycle1(input.Substring(counter + 1));
                        return result;
                    }
                    else if (EnteredOperation == '-')
                    {
                        int result = Int32.Parse(FirstEnteredNumber) - this.Cycle1(input.Substring(counter + 1));
                        return result;
                    }
                }
                else if ((counter + 1) == input.Length)
                {
                    return Int32.Parse(FirstEnteredNumber);
                }

                      

            }

            return 0;
            
       }

    }
}
