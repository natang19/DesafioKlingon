using Decifrandokinglon.Classes;
using System;
using System.Collections.Generic;

namespace Decifrandokinglon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto representando o tipo Foo dos kinglons
            Foo f = new Foo();

            //Objeto representando o alfabeto dos kinglons || Não consegui fazer funcionar.
            kinglonAlphabet ka = new kinglonAlphabet();

            //Objeto representando o numero dos klingons
            KinglonNumbers kn = new KinglonNumbers();

            string textB = System.IO.File.ReadAllText(@"{insira o caminho do seu texto aqui}/kinglon-TextB.txt");
            string[] wordsTextB = textB.Split(' ');

            var numberOfPrepositionsTextB = f.howManyPrepositions(wordsTextB);

            Console.WriteLine("O número de preposições do texto B é: " + numberOfPrepositionsTextB);

            var numberOfVerbsTextB = f.howManyVerbs(wordsTextB);

            Console.WriteLine("O número de verbos do texto B é: " + numberOfVerbsTextB);

            var numberOfVerbsTextBinFirstPersob = f.howManyVerbsInFirstPerson(wordsTextB);

            Console.WriteLine("O número de verbos do texto B em primeira pessoa é: " + numberOfVerbsTextBinFirstPersob);

            var numberOfBeatifulNumberInTextB = kn.HoyManyBeatifulNumbers(wordsTextB);

            Console.WriteLine("A quantidade de número bonitos do texto B é: " + numberOfBeatifulNumberInTextB);

            Console.ReadLine();
        }
    }
}
