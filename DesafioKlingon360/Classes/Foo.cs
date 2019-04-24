using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioKlingon360.Classes
{
    public class Foo
    {
        private string[] kinglonFoo = { "s", "l", "f", "w", "k" };
        public int howManyPrepositions(string[] words)
        {
            int numberOfFoo = 0;

            foreach (string word in words)
            {
                bool temD = word.ToUpper().Contains('D');

                if ((word.Length == 3) && (!temD) && endWithBar(word))
                {
                    numberOfFoo++;
                }
            }

            return numberOfFoo;
        }

        public int howManyVerbs(string[] words)
        {
            int numberOfVerbs = 0;

            foreach (string word in words)
            {
                if (word.Length >= 8 && endWithFoo(word))
                    numberOfVerbs++;
            }

            return numberOfVerbs;
        }

        public int howManyVerbsInFirstPerson(string[] words)
        {
            int numberOfVerbsInFirstPerson = 0;

            foreach (string word in words)
            {
                if (word.Length >= 8 && endWithFoo(word) && startWithBar(word))
                    numberOfVerbsInFirstPerson++;
            }

            return numberOfVerbsInFirstPerson;
        }

        private bool startWithBar(string word)
        {
            string fisrtLetter = word[0].ToString();

            for (int i = 0; i < kinglonFoo.Length; i++)
            {
                string fooArray = kinglonFoo[i].ToLower();

                if (fisrtLetter.Equals(fooArray))
                    return false;
            }

            return true;
        }

        private bool endWithBar(string word)
        {
            string lastLetter = word[word.Length - 1].ToString();

            for (int i = 0; i < kinglonFoo.Length; i++)
            {
                string fooArray = kinglonFoo[i].ToLower();

                if (lastLetter.Equals(fooArray))
                    return false;
            }

            return true;
        }

        private bool endWithFoo(string word)
        {
            string lastLetter = word[word.Length - 1].ToString();

            for (int i = 0; i < kinglonFoo.Length; i++)
            {
                string fooArray = kinglonFoo[i].ToLower();

                if (lastLetter.Equals(fooArray))
                    return true;
            }

            return false;
        }
    }
}
