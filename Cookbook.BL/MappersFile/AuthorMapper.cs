using AutoMapper;
using Cookbook.BL.Models;
using Cookbook.BL.Models.Author;
using Cookbook.DAL.Entities;
using Cookbook.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.MappersFile
{
    public class AuthorMapper : Profile
    {
        private readonly AuthorRepository _authorRepository = new AuthorRepository();
        private readonly IMapper _mapper;


        public AuthorMapper()
        {

        }
        public AuthorMapper(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AuthorsEntity, AuthorModel>();
                cfg.CreateMap<AuthorModel, AuthorsEntity>();
                cfg.CreateMap<AuthorsEntity, AuthorListModel>();
                cfg.CreateMap<AuthorListModel, AuthorsEntity>();

            });

            return config;
        }
        public List<AuthorListModel> MapAuthorEntityListToAuthorModelList()
        {
            var config = new Mapper(MapperConfiguration());
            var authorEntities = _authorRepository.GetAll();
            return config.Map<List<AuthorListModel>>(authorEntities);
        }
        public List<AuthorModel> MapListOfAuthorEntityToAuthorModel()
        {
            var config = new Mapper(MapperConfiguration());
            var authorEntities = _authorRepository.GetAll();
            return config.Map<List<AuthorModel>>(authorEntities);
        }
        public AuthorModel MapAuthorEntityToAuthorModel(AuthorsEntity authorsEntity)
        {
            var config = new Mapper(MapperConfiguration());
            return config.Map<AuthorModel>(authorsEntity);
        }

        public AuthorsEntity MapAuthorModelToAuthorEntity(AuthorModel authorModel)
        {
            var config = new Mapper(MapperConfiguration());
            return config.Map<AuthorsEntity>(authorModel);
        }

    }
}
