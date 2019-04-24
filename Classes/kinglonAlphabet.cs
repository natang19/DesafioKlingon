using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Decifrandokinglon.Classes
{
    public class kinglonAlphabet
    {
        //Alfabeto Klingon
        private string alphabetkinglon = "kbwrqdnfxjmlvhtcgzps";
        private Dictionary<string, string> auxList = new Dictionary<string, string>();

        public void orderByKlingonAlphabet(string[] words)
        {
            string[] wordsWithoutRepetitions = words.Distinct().ToArray();
            generateDictionarykinglonText(wordsWithoutRepetitions);
            var items = auxList.OrderBy(i => i.Key.Length);

            string nomeArquivo = @"C:\Users\natan\source\repos\Decifrandokinglon\TextBOrdered.txt";
            StreamWriter writer = new StreamWriter(nomeArquivo);

            foreach (var item in items)
            {
                writer.WriteLine(item.Value + " ");
            }

            writer.Close();
        }

        private void generateDictionarykinglonText(string[] words)
        {
            string keyId;
            foreach (string word in words)
            {
                keyId = generateId(word);
                auxList.Add(keyId, word);
            }
        }

        private string generateId(string word)
        {
            string Id = "";
            int indexFirstString = alphabetkinglon.IndexOf(word[0]) + 1;
            int indexNumber;
            for (int i = 0; i < word.Length; i++)
            {
                indexNumber = alphabetkinglon.IndexOf(word[i]);
                Id += ((indexNumber + 1)).ToString();
            }

            return Id = indexFirstString.ToString() + "-" + word.Length.ToString() + "-" + Id;
        }
    }
}
