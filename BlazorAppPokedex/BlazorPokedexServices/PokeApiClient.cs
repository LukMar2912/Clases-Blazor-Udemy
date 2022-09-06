using BlazorPokedexModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedexServices
{
    public class PokeApiClient : IPokeApiClient
    {
        private readonly HttpClient _httpClient;
        public PokeApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ResultObject> GetAllPokemon()
        {
           return JsonConvert.DeserializeObject<ResultObject>(
               await _httpClient.GetStringAsync($"pokemon?limit=20&offset=24"));

        }

        public async Task<Pokemon> GetPokemon(string name)
        {
            return JsonConvert.DeserializeObject<Pokemon>(
                await _httpClient.GetStringAsync($"pokemon/{name}"));
        }

        public Task<Pokemon> GetPokemonId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
