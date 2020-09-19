using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

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

        public CookbookDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CookbookDbContext>
        {
            public CookbookDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<CookbookDbContext>();
                optionsBuilder.UseMySQL(@"server=remotemysql.com;user id=wkL3rf6tSa; Password=QY2494NM6P; database=wkL3rf6tSa");

                return new CookbookDbContext(optionsBuilder.Options);
            }
        }

    }


    public class Class1
    {


    }
}
