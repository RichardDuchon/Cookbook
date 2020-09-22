using Cookbook.DAL;
using Cookbook.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL
{
    class UnitOfWork : IDisposable
    {

        public UnitOfWork(DbContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentException();
        }
        public DbContext DbContext { get; }

        public void Dispose()
        {
            DbContext.Dispose();
        }

        public void Complet()
        {
            DbContext.SaveChanges();
        }

    }
}
