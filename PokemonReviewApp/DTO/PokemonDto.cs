using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.DTO
{
    public class PokemonDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string FavoriteFood { get; set; }

        public bool IsWild { get; set; }

        [Range(0, 10, ErrorMessage = "Happiness level must be between 0 and 10.")]
        public int HappinessLevel { get; set; }
    }
}
