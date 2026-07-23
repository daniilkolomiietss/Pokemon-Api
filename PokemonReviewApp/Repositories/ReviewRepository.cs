using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;
using AutoMapper;

namespace PokemonReviewApp.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly AppDataContext _context;

        public ReviewRepository(AppDataContext context) => _context = context;
        public Review GetReview(int reviewId) => _context.Reviews.FirstOrDefault(r => r.Id == reviewId);
        public ICollection<Review> GetReviews() => _context.Reviews.ToList();
        public ICollection<Review> GetReviewsOfAPokemon(int pokeId) => _context.Reviews.Where(r => r.Pokemon.Id == pokeId).ToList();
        public bool ReviewExists(int reviewId) => _context.Reviews.Any(r => r.Id == reviewId);
    }
}
