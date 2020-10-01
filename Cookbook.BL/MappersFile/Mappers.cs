using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cookbook.BL.Models;
using Cookbook.BL.Models.Recipe;
using Cookbook.DAL.Entities;

namespace Cookbook.BL.MappersFile
{
    public class Mappers : Profile
    {
        private readonly IMapper _mapper;

        public Mappers()
        {

        }
        public Mappers(IMapper mapper)
        {
            this._mapper = mapper;
        }
        //Hotovo
        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(conf => conf.CreateMap<AuthorModel, AuthorsEntity>());
            var pes = new MapperConfiguration(con => con.CreateMap<AuthorsEntity, AuthorModel>());
            return config;
            //budou se muset vytvořit dvoje? Jedno model to entity a pak entity to model?
        }
        
       
        public AuthorsEntity MapAuthorModelToAuthorEntity(AuthorModel authorModel)
        {
            var config = new Mapper(MapperConfiguration());
            return config.Map<AuthorsEntity>(authorModel);
        }


        public AuthorModel MapAuthorEntityToAuthorModel(AuthorsEntity authorsEntity)
        {
            return _mapper.Map<AuthorModel>(authorsEntity);
        }
        
        public IEnumerable<AuthorModel> MapAuthorEntitiesListToAuthorModelsList(ICollection<AuthorsEntity> authorsEntities)
        {
            return _mapper.Map<IEnumerable<AuthorModel>>(authorsEntities);
        }

        public RecipeModel MapRecipeEntityToRecipeModel(RecipeEntity recipeEntity)
        {
            return _mapper.Map<RecipeModel>(recipeEntity);
        }


    }
}
