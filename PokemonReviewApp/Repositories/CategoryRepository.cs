using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDataContext _context;

        public CategoryRepository(AppDataContext context) => _context = context;

        public bool CategoryExists(int categoryId) => _context.Categories.Any(c => c.Id == categoryId);

        public ICollection<Category> GetCategories() => _context.Categories.ToList();

        public Category GetCategory(int id) => _context.Categories.FirstOrDefault(c => c.Id == id);

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId) => _context.PokemonCategories.Where(e => e.CategoryId == categoryId).Select(c => c.Pokemon).ToList();
    }
}
