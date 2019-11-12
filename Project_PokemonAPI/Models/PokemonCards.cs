using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_PokemonAPI.Models
{
    class PokemonCards
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }
        [JsonProperty(PropertyName = "nationalPokedexNumber")]
        public int dex { get; set; }
        [JsonProperty(PropertyName = "imageUrlid")]
        public string imgUrl { get; set; }
    }
}
