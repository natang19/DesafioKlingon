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

            //Objeto representando o alfabeto dos kinglons
            kinglonAlphabet ka = new kinglonAlphabet();

            KinglonNumbers kn = new KinglonNumbers();

            string textB = System.IO.File.ReadAllText(@"INSIRA O CAMINHO DO SEU ARQUIVO DO TEXT B AQUI");
            string[] wordsTextB = textB.Split(' ');

            var numberOfPrepositionsTextB = f.howManyPrepositions(wordsTextB);

            Console.WriteLine("O número de preposições do texto B é: " + numberOfPrepositionsTextB);

            var numberOfVerbsTextB = f.howManyVerbs(wordsTextB);

            Console.WriteLine("O número de verbos do texto B é: " + numberOfVerbsTextB);

            var numberOfVerbsTextBinFirstPersob = f.howManyVerbsInFirstPerson(wordsTextB);

            Console.WriteLine("O número de verbos do texto B em primeira pessoa é: " + numberOfVerbsTextBinFirstPersob);

            var numberOfBeatifulNumberInTextB = kn.HoyManyBeatifulNumbers(wordsTextB);

            Console.WriteLine("A quantidade de número bonitos do texto B é: " + numberOfBeatifulNumberInTextB);

            Console.Read();

            Console.ReadLine();
        }
    }
}
