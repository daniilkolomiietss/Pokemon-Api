using PokemonReviewApp.Data;
using PokemonReviewApp.Models;
using PokemonReviewApp.Interfaces;

namespace PokemonReviewApp.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly AppDataContext _context;
        public PokemonRepository(AppDataContext context) => _context = context;


        public ICollection<Pokemon> GetPokemons() => _context.Pokemons.OrderBy(p => p.Id).ToList();
        public Pokemon GetPokemon(int id) => _context.Pokemons.FirstOrDefault(p => p.Id == id);
        public Pokemon GetPokemon(string name) => _context.Pokemons.FirstOrDefault(p => p.Name == name);
        public decimal GetPokemonsRating(int pokeId)
        {
            var reviews = _context.Reviews.Where(r => r.Pokemon.Id == pokeId);

            if (!reviews.Any())
                return 0;

            return (decimal)reviews.Average(r => r.Rating);
        }
        public bool PokemonExists(int pokeId) => _context.Pokemons.Any(p => p.Id == pokeId);
    }
}