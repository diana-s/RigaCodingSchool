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
           string SecondEnteredNumber = "";
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
                    else
                    {
                        SecondEnteredNumber = SecondEnteredNumber + symbol;
                    }
                }
                
                if (OperationFound == true)
                {
                    if (EnteredOperation == '+')
                    {
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
