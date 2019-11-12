using Newtonsoft.Json;
using Project_PokemonAPI.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Project_PokemonAPI.Repositories
{
    class PokemonRepository
    {
        private static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            return client;
        }

        public static async Task<PokemonCards> GetPokemonCardsAsync()
        {
            string url = $"https://api.pokemontcg.io/v1/cards";

            //Create and use HttpClient
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    PokemonCards result = new PokemonCards();
                    //Ask for JSON data
                    string content = await client.GetStringAsync(url);
                    //Convert data to Quote object
                    PokemonCards cards = JsonConvert.DeserializeObject<PokemonCards>(content);
                    foreach (var card in cards)
                    {
                        result.Add(card);
                    }
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
