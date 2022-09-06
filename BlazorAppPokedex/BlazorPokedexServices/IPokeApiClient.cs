using BlazorPokedexModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedexServices
{
    public interface IPokeApiClient
    {
        Task<ResultObject> GetAllPokemon();
        Task<Pokemon> GetPokemon(string name);
        Task<Pokemon> GetPokemonId(int id);
    }
}
