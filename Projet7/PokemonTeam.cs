﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Projet7
{
    public class PokemonTeam
    {
        public Pokemon[] PT;
        public static PokemonTeam CreateTeam()
        {
            PokemonTeam Pt = new PokemonTeam();
            Pt.PT = new Pokemon[1];
            Random rId = new Random();
            Random rLvl = new Random();
            int opponentPokemonId = rId.Next(1, 613);
            int opponentPokemonLvl = rLvl.Next(5, 10);

            Pokemon opponentP = Pokemon.GetPokemon(opponentPokemonId, opponentPokemonLvl);

            Console.WriteLine(opponentP.name["french"]);
            Console.WriteLine("lvl " + opponentP.level);
            Console.WriteLine("Hp " + opponentP.currentHp + "/" + opponentP.Base["HP"]);
            Console.WriteLine("Stat :");
            Console.WriteLine(opponentP.Base["Attack"]);
            Console.WriteLine(opponentP.Base["Defense"]);
            Console.WriteLine(opponentP.Base["Sp. Attack"]);
            Console.WriteLine(opponentP.Base["Sp. Defense"]);
            Console.WriteLine(opponentP.Base["Speed"]);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(opponentP.attack[i].ename + " " + opponentP.attack[i].category);
            }
            Pt.PT[0] = opponentP;
            return Pt;
        }

        public static PokemonTeam CreateGymLeader()
        {
            PokemonTeam Pt = new PokemonTeam();
            Pt.PT = new Pokemon[1];
            Random rId = new Random();
            Random rLvl = new Random();
            int opponentPokemonId = rId.Next(1, 613);
            int opponentPokemonLvl = rLvl.Next(11, 15);

            Pokemon opponentP = Pokemon.GetPokemon(opponentPokemonId, opponentPokemonLvl);

            Console.WriteLine(opponentP.name["french"]);
            Console.WriteLine("lvl " + opponentP.level);
            Console.WriteLine("Hp " + opponentP.currentHp + "/" + opponentP.Base["HP"]);
            Console.WriteLine("Stat :");
            Console.WriteLine(opponentP.Base["Attack"]);
            Console.WriteLine(opponentP.Base["Defense"]);
            Console.WriteLine(opponentP.Base["Sp. Attack"]);
            Console.WriteLine(opponentP.Base["Sp. Defense"]);
            Console.WriteLine(opponentP.Base["Speed"]);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(opponentP.attack[i].ename + " " + opponentP.attack[i].category);
            }
            Pt.PT[0] = opponentP;
            return Pt;
        }
    }
}