﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Projet7
{
    [Serializable]
    public class Teams
    {
        [JsonInclude]
        public PokemonTeam[] pokemonTeam;

    }

    [Serializable]
    public class PokemonTeam
    {
        static Dictionary<int, PokemonTeam> _pokemonTeam;

        static PokemonTeam()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var json = File.ReadAllText("../../../trainerTeam.json");
            var teams = JsonSerializer.Deserialize<Teams>(json, options);
            _pokemonTeam = new Dictionary<int, PokemonTeam>(teams.pokemonTeam.Select(i => new KeyValuePair<int, PokemonTeam>(i.teamid, i)));
        }

        [JsonInclude]
        public int teamid;
        [JsonInclude]
        public Team[] team;
        //[JsonInclude]
        //public string name;
        //[JsonInclude]
        //public int lvl;
        //[JsonInclude]
        //public Dictionary<string, string> skills;

        public static PokemonTeam GetTeam(int teamid)
        {
            var tId = _pokemonTeam.GetValueOrDefault(teamid);

            var newTeam = new PokemonTeam()
            {
                teamid = tId.teamid,
                name = tId.name,
                lvl = tId.lvl,
                skills = new Dictionary<string, string>(tId.skills)
            };
            return newTeam;
        }
    }
}
