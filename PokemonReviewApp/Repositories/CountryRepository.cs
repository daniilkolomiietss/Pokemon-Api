using AutoMapper;
using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly AppDataContext _context;
        private readonly IMapper _mapper;

        public CountryRepository(AppDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool CountryExists(int id) => _context.Countries.Any(c => c.Id == id);
        public Country GetCountry(int id) => _context.Countries.FirstOrDefault(c => c.Id == id);
        public ICollection<Country> GetCountries() => _context.Countries.ToList();
        public Country GetCountryByOwner(int ownerId) => _context.Owners.Where(o => o.Id == ownerId).Select(o => o.Country).FirstOrDefault();
        public ICollection<Owner> GetOwnersFromCountry(int countryId) => _context.Owners.Where(o => o.Country.Id == countryId).ToList();
    }
}