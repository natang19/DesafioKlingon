using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decifrandokinglon.Classes
{
    public class KinglonNumbers
    {
        List<long> ListTextNumbers = new List<long>();
        /**Eu preferi usar o alfabeto klingon como string para facilitar a conversão para número tomando como base nos próprios indices de cada letra da string que representa o alfabeto klingon**/
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
                //Pega a posição (indice) da letra na string
                int positionLetter = alphabetkinglon.IndexOf(word[i]);
                //tranforma a letra em um número de acordo com a base klingon
                number += Convert.ToInt64(positionLetter * Math.Pow(20, i));
            }

            ListTextNumbers.Add(number);
        }
    }
}
