using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cookbook.BL.Models;
using Cookbook.DAL.Entities;

namespace Cookbook.BL.MappersFile
{
    public class Mappers : Profile
    {
        private readonly IMapper _mapper;
        //vše se tady musí upravit na ten config aby se používal jako v 1

        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(conf => conf.CreateMap<AuthorModel, AuthorsEntity>());

            CreateMap<AuthorModel, AuthorsEntity>();
            return config;

            //var config = new MapperConfiguration(conf => conf.CreateMap<AuthorsEntity, AuthorModel>()); // budou se muset vytvořit dvoje? Jedno model to entity a pak entity to model?

            //CreateMap<AuthorsEntity, AuthorModel>();
            //return config;
        }
        public Mappers()
        {

        }
        public Mappers(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public AuthorModel MapAuthorEntityToAuthorModel(AuthorsEntity authorsEntity)
        {
            return _mapper.Map<AuthorModel>(authorsEntity);
        }
        public AuthorsEntity MapAuthorModelToAuthorEntity(AuthorModel authorModel)
        {
            //1

            var config = new Mapper(MapperConfiguration());

            return config.Map<AuthorsEntity>(authorModel);
        }

        public IEnumerable<AuthorModel> MapAuthorEntitiesListToAuthorModelsList(ICollection<AuthorsEntity> authorsEntities)
        {
            return _mapper.Map<IEnumerable<AuthorModel>>(authorsEntities);
        }

        public RecipeNameModel MapRecipeEntityToRecipeNameModel(RecipeEntity recipeEntity)
        {
            return _mapper.Map<RecipeNameModel>(recipeEntity);
        }

        public RecipeModel MapRecipeEntityToRecipeModel(RecipeEntity recipeEntity)
        {
            return _mapper.Map<RecipeModel>(recipeEntity);
        }


    }
}
