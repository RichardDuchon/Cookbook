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

            //modelBuilder.Entity<RecipeEntity>().HasMany(t => t.IngredientEntities).WithOne(t => t.Recipe);
            //modelBuilder.Entity<IngredientEntity>().HasOne(t => t.Recipe).WithMany(t => t.IngredientEntities);
        }

    }

}
