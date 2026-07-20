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
        }
    }
}
