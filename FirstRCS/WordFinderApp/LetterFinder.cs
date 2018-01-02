using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WordFinderApp

{
    class LetterFinder

        
    {
        public int LetterAnalyzer(string input)
        {
            string EnteredLetters = " ";
            bool LetterFound = false;

            int counter = 0;
            while (counter<input.Length)
            {
                string letter = Match


                    public static IEnumerable<int> IndexOfAll(this string sourceString, string matchString)
                {
                    matchString = Regex.Escape(matchString);
                    return from Match match in Regex.Matches(sourceString, matchString) select match.Index;
                }


            }









            return 0;

        }

    }
}
