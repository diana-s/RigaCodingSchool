using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterBestCalculator
{
    class Class2
    {
        public int Cycle2(string input)
        {
            var FirstEnteredNumber2 = "";
            var SecondEnteredNumber2 = "";
            char EnteredOperation2 = ' ';
            bool OperationFound2 = false;

            int counter = 0;
            while (counter < input.Length)
            {
                char sub = input[counter];
                if (sub != '-')
                {
                    EnteredOperation2 = sub;
                    OperationFound2 = false;
                }
                else
                {
                    if (OperationFound2 == false)
                    {
                        FirstEnteredNumber2 = FirstEnteredNumber2 + sub;

                    }
                    else
                    {
                        SecondEnteredNumber2 = SecondEnteredNumber2 + sub;
                    }
                }

                counter = counter + 1;


                if (OperationFound2 == true && counter == input.Length)
                {
                    var result2 = int.Parse(FirstEnteredNumber2) - int.Parse(SecondEnteredNumber2);
                    return result2;
                }

            }
            return 0;
        }
    }
}

