using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pokemon pokemon1 = new Pokemon("파이리", 100, 200);
            Pokemon pokemon2 = new Pokemon("피카츄", 80, 250.5f);
            Pokemon pokemon3 = new Pokemon("꼬부기", 150, 145.8f);
            //curPokemon.Name = "파이리";
            //curPokemon.Hp = 100;

            List<Pokemon> pokemonList = new List<Pokemon>();
            pokemonList.Add(pokemon1);
            pokemonList.Add(pokemon2);
            pokemonList.Add(pokemon3);

            for (int i = 0; i < pokemonList.Count; i++)
            {
                pokemonList[i].Skill();
            }
        }

        static void print(object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
