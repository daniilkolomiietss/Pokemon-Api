using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repositories
{
    public class ReviewerRepository : IReviewerRepository
    {
        private readonly AppDataContext _context;

        public ReviewerRepository(AppDataContext context) => _context = context;
        public ICollection<Reviewer> GetReviewers() => _context.Reviewers.ToList();
        public Reviewer GetReviewer(int reviewerId) => _context.Reviewers.FirstOrDefault(r => r.Id == reviewerId);
        public ICollection<Review> GetReviewsByReviewer(int reviewerId) => _context.Reviews.Where(r => r.Reviewer.Id == reviewerId).ToList();
        public bool ReviewerExists(int reviewerId) => _context.Reviewers.Any(r => r.Id == reviewerId);
    }
}
