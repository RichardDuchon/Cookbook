using AutoMapper;
using Cookbook.BL.Models;
using Cookbook.DAL.Entities;
using Cookbook.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.MappersFile
{
    class RecipeMapper : Profile
    {
        private readonly RecipeRepository _recipeRepository = new RecipeRepository();

        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RecipeEntity, RecipeModel>();
                cfg.CreateMap<RecipeModel, RecipeEntity>();
            });

            return config;
        }

        public List<RecipeModel> MapRecipeEntityListToRecipeModelList()
        {
            var config = new Mapper(MapperConfiguration());
            var recipeEntities = _recipeRepository.GetAll();
            return config.Map<List<RecipeModel>>(recipeEntities);
        }
        public RecipeModel MapRecipeEntityToRecipeModel(RecipeEntity recipeEntity)
        {
            var config = new Mapper(MapperConfiguration());
            return config.Map<RecipeModel>(recipeEntity);
        }

        public RecipeEntity MapRecipeModelToRecipeEntity(RecipeModel recipeModel)
        {
            //tohle
            var config = new Mapper(MapperConfiguration());
            return config.Map<RecipeEntity>(recipeModel);
        }
    }
}
