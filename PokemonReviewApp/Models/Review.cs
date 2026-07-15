namespace PokemonReviewApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Rating { get; set 
            { 
                if (value < 1 || value > 10)
                    throw new ArgumentOutOfRangeException(nameof(Rating), "Rating must be between 1 and 10");
                field = value;
            } }
        public Reviewer Reviewer { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}