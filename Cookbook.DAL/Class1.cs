using Microsoft.EntityFrameworkCore;

namespace Cookbook.DAL
{

    public class CookbookDbContext : DbContext
    {
        public DbSet<NutritionalValuesEntity> NutritionalValues { get; set; }
        public DbSet<IngredientEntity> Ingredients { get; set; }
        public DbSet<UnitEntity> Unit { get; set; }
        public DbSet<AuthorsEntity> Author { get; set; }
        public DbSet<ReviewEntity> Review { get; set; }
        public DbSet<RecipeEntity> Recipe { get; set; }

    }


    public class Class1
    {


    }
}
