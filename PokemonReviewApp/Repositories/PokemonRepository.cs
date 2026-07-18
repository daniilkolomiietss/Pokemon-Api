using PokemonReviewApp.Data;
using PokemonReviewApp.Models;
using PokemonReviewApp.Interfaces;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly AppDataContext _context;
        public PokemonRepository(AppDataContext context) => _context = context;


        public ICollection<Pokemon> GetPokemons() => _context.Pokemons.OrderBy(p => p.Id).ToList();
    }
}