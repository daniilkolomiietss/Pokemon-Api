namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FavoriteFood { get; set; }
        public bool IsWild { get; set; }
        public int HappinessLevel
        {
            get; set
            {
                if (value < 0 && value > 10)
                    throw new ArgumentOutOfRangeException(nameof(HappinessLevel), "Happiness level cannot be negative or bigger than 10");
                field = value;
            }
        }
        public ICollection<Review> Reviews { get; set; }
    }
}