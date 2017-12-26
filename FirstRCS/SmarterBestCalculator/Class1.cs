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

            int counter = 0;
            while(counter < input.Length)
            {
                char symbol = input[counter];
                if (symbol == '+')
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

                counter = counter + 1;
                if (OperationFound == true && counter == input.Length)
                {
                    int result = Int32.Parse(FirstEnteredNumber) + Int32.Parse(SecondEnteredNumber);
                    return result;
                }

                      

            }

            return 0;


       }

    }
}
