using Cookbook.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cookbook.DAL
{


    public partial class CookbookDbContext : DbContext
    {
        public DbSet<NutritionalValuesEntity> NutritionalValues { get; set; }
        public DbSet<IngredientEntity> Ingredients { get; set; }
        public DbSet<UnitEntity> Unit { get; set; }
        public DbSet<AuthorsEntity> Author { get; set; }
        public DbSet<ReviewEntity> Review { get; set; }
        public DbSet<RecipeEntity> Recipe { get; set; }
        public DbSet<IngredientRecipeEntity> IngredientRecipes { get; set; }

        public CookbookDbContext()
        {

        }
        public CookbookDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IngredientRecipeEntity>().HasKey(sc => new { sc.RecipeId, sc.IngredientId });
            modelBuilder.Entity<AuthorsEntity>().HasMany(e => e.Recipes).WithOne(e => e.Author);
            modelBuilder.Entity<AuthorsEntity>().HasMany(e => e.Reviews).WithOne(e => e.Author);
            modelBuilder.Entity<RecipeEntity>().HasOne(e => e.NutritionalValues).WithOne(e => e.Recipe).HasForeignKey<NutritionalValuesEntity>(e=>e.RecipeId);
        }
    }
}
