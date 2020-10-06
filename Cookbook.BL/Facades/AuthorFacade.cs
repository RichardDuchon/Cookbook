using AutoMapper;
using Cookbook.BL.MappersFile;
using Cookbook.BL.Models;
using Cookbook.BL.Models.Author;
using Cookbook.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Facades
{
    public class AuthorFacade
    {
        private readonly AuthorRepository _authorRepository = new AuthorRepository();
        private readonly AuthorMapper _authorMapper = new AuthorMapper();

        public void Delete(AuthorModel obj)
        {
            var author = _authorMapper.MapAuthorModelToAuthorEntity(obj);
            _authorRepository.Delete(author);
        }

        public List<AuthorListModel> GetAllListModels()
        {
            return _authorMapper.MapAuthorEntityListToAuthorModelList();
        }

        public List<AuthorModel> GetAllModels()
        {
            return _authorMapper.MapListOfAuthorEntityToAuthorModel();
        }
            
        public AuthorModel GetById(int id)
        {
            var author = _authorRepository.GetById(id);
            return _authorMapper.MapAuthorEntityToAuthorModel(author);
        }
    }
}
