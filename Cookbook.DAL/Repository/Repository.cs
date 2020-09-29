using Cookbook.DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cookbook.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DefaultDbContextFactory _defaultDbContextFactory = new DefaultDbContextFactory();

        public void Add(T obj)
        {
            using (var dbContext = _defaultDbContextFactory.CreateDbContext())
            {
                dbContext.Set<T>().Add(obj);
                dbContext.SaveChanges();
            }
        }

        public void Delete(T obj)
        {
            using (var dbContext = _defaultDbContextFactory.CreateDbContext())
            {
                dbContext.Set<T>().Remove(obj);
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var dbContext = _defaultDbContextFactory.CreateDbContext())
            {
                return dbContext.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var dbContext = _defaultDbContextFactory.CreateDbContext())
            {
                return dbContext.Set<T>().Find(id);
            }
        }

        public void Save()
        {
            using (var dbContext = _defaultDbContextFactory.CreateDbContext())
            {
                dbContext.SaveChanges();
            }
        }

        public void Update(T obj)
        {
            using (var dbContext = _defaultDbContextFactory.CreateDbContext())
            {
                dbContext.Dispose();
            }
        }
    }
}
