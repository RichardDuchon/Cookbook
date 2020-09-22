using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.DAL
{
    public interface IDbContextFactory
    {
        CookbookDbContext CreateDbContext();
    }
}
