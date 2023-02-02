﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Projet7
{
    public class Player
    {

        public int[] PlayerPos { get; set; }
        public int Money { get; set; }
        public List<Pokemon> ListPokemonTeam { get; set; }

        public void InitWIthoutJSon(int x, int y)
        {
            Random rId = new Random();
            int PokemonId = rId.Next(1, 613);
            Pokemon pokemon = Pokemon.GetPokemon(PokemonId, 5);
            ListPokemonTeam = new List<Pokemon>{};
            ListPokemonTeam.Add(pokemon);
            //_pokemonTeam.CreateTeam();
            PlayerPos = new int[2];
            PlayerPos[0] = x;
            PlayerPos[1] = y;
            Money = 0;
        }

        public void Inputs(Map _map)
        {
            ConsoleKeyInfo input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.Q:
                    if (input.Modifiers == ConsoleModifiers.Shift)
                    {
                        int i;
                        for (i = 0; i <= 3; i++)
                        {

                            if (_map.GetMap()[PlayerPos[1], PlayerPos[0] - i] != '#' && _map.GetMap()[PlayerPos[1], PlayerPos[0] - i] != '/' && _map.GetMap()[PlayerPos[1], PlayerPos[0] - i] != '-' && _map.GetMap()[PlayerPos[1], PlayerPos[0] - i] != 'C' && _map.GetMap()[PlayerPos[1], PlayerPos[0] - i] != '~')
                            {
                                if (i != 0 && _map.GetMap()[PlayerPos[1], PlayerPos[0] - i] == 'w')
                                {
                                    Random rand = new Random();
                                    int wildEncounter = rand.Next(5);
                                    if (wildEncounter == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("A wild pokemon appeared");
                                        _map.WildBattle = true;
                                        break;
                                    }
                                }
                                for (int j = 0; j < 6; j++)
                                {
                                    if (_map.GetMap()[PlayerPos[1], PlayerPos[0] - i] == '!')
                                    {
                                        Console.WriteLine("Trainer");
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }

                        }
                        PlayerPos[0] = PlayerPos[0] - (i - 1);
                    }
                    else
                    {
                        if (_map.GetMap()[PlayerPos[1], PlayerPos[0] - 1] != '#' && _map.GetMap()[PlayerPos[1], PlayerPos[0] - 1] != '/' && _map.GetMap()[PlayerPos[1], PlayerPos[0] - 1] != '-' && _map.GetMap()[PlayerPos[1], PlayerPos[0] - 1] != 'C' && _map.GetMap()[PlayerPos[1], PlayerPos[0] - 1] != '~')
                        {
                            PlayerPos[0] = PlayerPos[0] - 1;

                        }
                    }
                    break;


                case ConsoleKey.Z:
                    if (input.Modifiers == ConsoleModifiers.Shift)
                    {
                        int i;
                        for (i = 0; i <= 3; i++)
                        {

                            if (_map.GetMap()[PlayerPos[1] - i, PlayerPos[0]] != '#' && _map.GetMap()[PlayerPos[1] - i, PlayerPos[0]] != '_' && _map.GetMap()[PlayerPos[1] - i, PlayerPos[0]] != '/' && _map.GetMap()[PlayerPos[1] - i, PlayerPos[0]] != 'C' && _map.GetMap()[PlayerPos[1] - i, PlayerPos[0]] != '-' && _map.GetMap()[PlayerPos[1] - i, PlayerPos[0]] != '~')
                            {
                                if (_map.GetMap()[PlayerPos[1] - i, PlayerPos[0]] == 'c')
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Your pokemons has been healed");
                                    break;
                                }
                                else if (i != 0 && _map.GetMap()[PlayerPos[1] - i, PlayerPos[0]] == 'w')
                                {
                                    Random rand = new Random();
                                    int wildEncounter = rand.Next(5);
                                    if (wildEncounter == 1)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("A wild pokemon appeared");
                                        break;
                                    }
                                }
                                for (int j = 0; j < 6; j++)
                                {
                                    if (_map.GetMap()[PlayerPos[1] - i, PlayerPos[0] - j] == '!' || _map.GetMap()[PlayerPos[1] - i, PlayerPos[0] + j] == '!' || _map.GetMap()[PlayerPos[1] - i - j, PlayerPos[0]] == '!' || _map.GetMap()[PlayerPos[1] - i + j, PlayerPos[0]] == '!')
                                    {
                                        Console.WriteLine("Trainer");
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }

                        }
                        PlayerPos[1] = PlayerPos[1] - (i - 1);
                    }
                    else
                    {
                        if (_map.GetMap()[PlayerPos[1] - 1, PlayerPos[0]] != '#' && _map.GetMap()[PlayerPos[1] - 1, PlayerPos[0]] != '_' && _map.GetMap()[PlayerPos[1] - 1, PlayerPos[0]] != '/' && _map.GetMap()[PlayerPos[1] - 1, PlayerPos[0]] != 'C' && _map.GetMap()[PlayerPos[1] - 1, PlayerPos[0]] != '-' && _map.GetMap()[PlayerPos[1] - 1, PlayerPos[0]] != '~')
                        {
                            if (_map.GetMap()[PlayerPos[1] - 1, PlayerPos[0]] == 'c')
                            {
                                Console.WriteLine();
                                Console.WriteLine("Your pokemons has been healed");
                            }
                            else
                            {
                                PlayerPos[1] = PlayerPos[1] - 1;
                            }

                        }
                    }

                    break;

                case ConsoleKey.D:
                    if (input.Modifiers == ConsoleModifiers.Shift)
                    {
                        int i;
                        for (i = 0; i <= 3; i++)
                        {
                            if (_map.GetMap()[PlayerPos[1], PlayerPos[0] + i] != '#' && _map.GetMap()[PlayerPos[1], PlayerPos[0] + i] != '/' && _map.GetMap()[PlayerPos[1], PlayerPos[0] + i] != 'C' && _map.GetMap()[PlayerPos[1], PlayerPos[0] + i] != '-' && _map.GetMap()[PlayerPos[1], PlayerPos[0] + i] != '~')
                            {
                                if (i != 0 && _map.GetMap()[PlayerPos[1], PlayerPos[0] + i] == 'w')
                                {
                                    Random rand = new Random();
                                    int wildEncounter = rand.Next(5);
                                    if (wildEncounter == 1)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("A wild pokemon appeared");
                                        break;
                                    }
                                }
                                for (int j = 0; j < 6; j++)
                                {
                                    if (_map.GetMap()[PlayerPos[1], PlayerPos[0] + i - j] == '!' || _map.GetMap()[PlayerPos[1], PlayerPos[0] + i + j] == '!' || _map.GetMap()[PlayerPos[1] - j, PlayerPos[0] + i] == '!' || _map.GetMap()[PlayerPos[1] + j, PlayerPos[0] + i] == '!')
                                    {
                                        Console.WriteLine("Trainer");
                                        break;
                                    }
                                }

                            }

                            else
                            {
                                break;
                            }

                        }
                        PlayerPos[0] = PlayerPos[0] + (i - 1);
                    }
                    else
                    {
                        if (_map.GetMap()[PlayerPos[1], PlayerPos[0] + 1] != '#' && _map.GetMap()[PlayerPos[1], PlayerPos[0] + 1] != '/' && _map.GetMap()[PlayerPos[1], PlayerPos[0] + 1] != 'C' && _map.GetMap()[PlayerPos[1], PlayerPos[0] + 1] != '-' && _map.GetMap()[PlayerPos[1], PlayerPos[0] + 1] != '~')
                        {

                            PlayerPos[0] = PlayerPos[0] + 1;

                        }
                    }
                    break;

                case ConsoleKey.S:
                    if (input.Modifiers == ConsoleModifiers.Shift)
                    {
                        int i;
                        bool jump = false;
                        for (i = 0; i <= 3; i++)
                        {
                            if (_map.GetMap()[PlayerPos[1] + i, PlayerPos[0]] != '#' && _map.GetMap()[PlayerPos[1] + i, PlayerPos[0]] != '_' && _map.GetMap()[PlayerPos[1] + i, PlayerPos[0]] != '/' && _map.GetMap()[PlayerPos[1] + i, PlayerPos[0]] != 'C' && _map.GetMap()[PlayerPos[1] + i, PlayerPos[0]] != '~')
                            {
                                if (_map.GetMap()[PlayerPos[1] + i, PlayerPos[0]] == '-')
                                {
                                    jump = true;
                                }
                                else if (_map.GetMap()[PlayerPos[1] + i, PlayerPos[0]] == 'c')
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Your pokemons has been healed");
                                    break;
                                }
                                else if (i != 0 && _map.GetMap()[PlayerPos[1] + i, PlayerPos[0]] == 'w')
                                {
                                    Random rand = new Random();
                                    int wildEncounter = rand.Next(5);
                                    if (wildEncounter == 1)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("A wild pokemon appeared");
                                        break;
                                    }
                                }
                                for (int j = 0; j < 6; j++)
                                {
                                    if (_map.GetMap()[PlayerPos[1] + i, PlayerPos[0] - j] == '!' || _map.GetMap()[PlayerPos[1] + i, PlayerPos[0] + j] == '!' || _map.GetMap()[PlayerPos[1] + i - j, PlayerPos[0]] == '!' || _map.GetMap()[PlayerPos[1] + i + j, PlayerPos[0] + i] == '!')
                                    {
                                        Console.WriteLine("Trainer");
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }

                        }
                        if (jump)
                        {
                            PlayerPos[1] = PlayerPos[1] + (i);
                        }
                        else
                            PlayerPos[1] = PlayerPos[1] + (i - 1);
                    }
                    else
                    {
                        if (_map.GetMap()[PlayerPos[1] + 1, PlayerPos[0]] != '#' && _map.GetMap()[PlayerPos[1] + 1, PlayerPos[0]] != '_' && _map.GetMap()[PlayerPos[1] + 1, PlayerPos[0]] != '/' && _map.GetMap()[PlayerPos[1] + 1, PlayerPos[0]] != 'C' && _map.GetMap()[PlayerPos[1] + 1, PlayerPos[0]] != '~')
                        {
                            if (_map.GetMap()[PlayerPos[1] + 1, PlayerPos[0]] == '-')
                            {
                                PlayerPos[1] = PlayerPos[1] + 2;
                            }
                            else if (_map.GetMap()[PlayerPos[1] + 1, PlayerPos[0]] == 'c')
                            {
                                Console.WriteLine();
                                Console.WriteLine("Your pokemons has been healed");
                            }
                            else
                            {
                                PlayerPos[1] = PlayerPos[1] + 1;
                            }

                        }
                    }
                    break;
                case ConsoleKey.Escape:
                    _map.Menu = true;
                    break;

                default:
                    break;
            }
            if (_map.GetMap()[PlayerPos[1], PlayerPos[0]] == 'w')
            {
                Random rand = new Random();
                int wildEncounter = rand.Next(5);
                if (wildEncounter == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("A wild pokemon appeared");
                }
            }
            for (int j = 0; j < 6; j++)
            {
                if (_map.GetMap()[PlayerPos[1], PlayerPos[0] - j] == '!' || _map.GetMap()[PlayerPos[1], PlayerPos[0] + j] == '!' || _map.GetMap()[PlayerPos[1] - j, PlayerPos[0]] == '!' || _map.GetMap()[PlayerPos[1] + j, PlayerPos[0]] == '!')
                {
                    Console.WriteLine("Trainer");
                    break;
                }
            }
            if (!_map.Paused)
            {
                _map.ShowMap(PlayerPos);
            }
        }
        
        public void printPokemonTeam()
        {
            foreach(Pokemon p in ListPokemonTeam)
            {
                Console.WriteLine(p.name);
            }
        }
    }
}