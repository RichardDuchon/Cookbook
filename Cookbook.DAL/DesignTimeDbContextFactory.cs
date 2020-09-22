using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Cookbook.DAL
{


    public partial class CookbookDbContext
    {
        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CookbookDbContext>
        {
            public CookbookDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<CookbookDbContext>();
                optionsBuilder.UseMySQL(@"server=remotemysql.com;user id=FDS59fD6eh; Password=SIdzW9oepC; database=FDS59fD6eh");

                return new CookbookDbContext(optionsBuilder.Options);
            }
        }

    }
}
