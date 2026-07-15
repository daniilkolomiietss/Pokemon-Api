using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }
        public DbSet<PokemonCategory> PokemonCategories { get; set; }
        public DbSet<PokemonOwner> PokemonOwners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCategory>()
                .HasKey(join => new { join.PokemonId, join.CategoryId });
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(join => join.Pokemon)
                .WithMany(pok => pok.PokemonCategories)
                .HasForeignKey(join => join.PokemonId);
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(join => join.Category)
                .WithMany(cat => cat.PokemonCategories)
                .HasForeignKey(join => join.CategoryId);

            modelBuilder.Entity<PokemonOwner>()
                .HasKey(join => new { join.PokemonId, join.OwnerId });
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(join => join.Pokemon)
                .WithMany(pok => pok.PokemonOwners)
                .HasForeignKey(join => join.PokemonId);
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(join => join.Owner)
                .WithMany(own => own.PokemonOwners)
                .HasForeignKey(join => join.OwnerId);
        }
    }
}