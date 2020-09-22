using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.DAL
{
    public class DefaultDbContextFactory : IDbContextFactory
    {
        public CookbookDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CookbookDbContext>();
            optionsBuilder.UseMySQL("server=remotemysql.com;user id=FDS59fD6eh; Password=SIdzW9oepC; database=FDS59fD6eh");
            return new CookbookDbContext(optionsBuilder.Options);
        }
    }
}
