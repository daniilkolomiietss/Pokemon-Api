using AutoMapper;
using PokemonReviewApp.Models;
using PokemonReviewApp.DTO;

namespace PokemonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Owner, OwnerDto>();
            CreateMap<Reviewer, ReviewerDto>();
            CreateMap<Review, ReviewDto>();
        }
    }
}
