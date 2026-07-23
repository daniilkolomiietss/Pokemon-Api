using PokemonReviewApp.Data;
using PokemonReviewApp.Models;
using PokemonReviewApp.Interfaces;

namespace PokemonReviewApp.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private AppDataContext _context;

        public OwnerRepository(AppDataContext context) => _context = context;

        public Owner GetOwner(int ownerId) => _context.Owners.FirstOrDefault(o => o.Id == ownerId);
        public ICollection<Owner> GetOwners() => _context.Owners.OrderBy(o => o.Id).ToList();
        public ICollection<Owner> GetOwnersOfAPokemon(int pokeId) => _context.PokemonOwners.Where(po => po.Pokemon.Id == pokeId).Select(po => po.Owner).ToList();
        public ICollection<Pokemon> GetPokemonByOwner(int ownerId) => _context.PokemonOwners.Where(po => po.Owner.Id == ownerId).Select(po => po.Pokemon).ToList();
        public bool OwnerExists(int ownerId) => _context.Owners.Any(o => o.Id == ownerId);
    }
}