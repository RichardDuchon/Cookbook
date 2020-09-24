using Cookbook.BL.MappersFile;
using Cookbook.BL.Models;
using Cookbook.BL.Repository.Interface;
using Cookbook.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Cookbook.BL.Repository
{
    public class AuthorRepository : IRepository<AuthorModel>
    {
        private DefaultDbContextFactory _defaultDbContextFactory;
        private Mappers _mappers;


        public AuthorRepository()
        {

        }
        public AuthorRepository(DefaultDbContextFactory defaultDbContextFactory, Mappers mappers)
        {
            this._defaultDbContextFactory = defaultDbContextFactory;
            this._mappers = mappers;
        }
        public void Add(AuthorModel obj)
        {
            using (var dbContext = _defaultDbContextFactory.CreateDbContext())
            {
                dbContext.Author.Add(_mappers.MapAuthorModelToAuthorEntity(obj));
                dbContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var dbContext = _defaultDbContextFactory.CreateDbContext())
            {
                dbContext.Author.Remove(dbContext.Author.Find(id));
                dbContext.SaveChanges();
            }


        }

        public IEnumerable<AuthorModel> GetAll()
        {
            using (var dbContext = _defaultDbContextFactory.CreateDbContext())
            {
                return _mappers.MapAuthorEntitiesListToAuthorModelsList(dbContext.Author.ToList());
            }

        }

        public AuthorModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(AuthorModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
