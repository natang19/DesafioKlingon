using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decifrandokinglon.Classes
{
    public class KinglonNumbers
    {
        List<long> ListTextNumbers = new List<long>();
        private string alphabetkinglon = "kbwrqdnfxjmlvhtcgzps";

        public int HoyManyBeatifulNumbers(string[] words)
        {
            int beatifulNumber = 0;

            foreach (string word in words)
            {
                convertToNumber(word);
            }

            foreach (var number in ListTextNumbers)
            {
                if((number >= 440566) && (number%3 == 0))
                {
                    beatifulNumber++;
                }
            }

            return beatifulNumber;
        }

        private void convertToNumber(string word)
        {
            long number=0;

            for (int i = word.Length-1; i >= 0; i--)
            {
                int positionLetter = alphabetkinglon.IndexOf(word[i]);
                number += Convert.ToInt64(positionLetter * Math.Pow(20, i));
            }

            ListTextNumbers.Add(number);
        }
    }
}
