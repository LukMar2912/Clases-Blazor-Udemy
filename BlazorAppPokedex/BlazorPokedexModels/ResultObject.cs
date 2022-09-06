using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedexModels
{
    public class ResultObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public IEnumerable<Pokemon> Pokemons { get; set; }
    }
}
