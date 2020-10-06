using AutoMapper;
using Cookbook.BL.Models;
using Cookbook.BL.Models.Recipe;
using Cookbook.DAL.Entities;
using Cookbook.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
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
                cfg.CreateMap<RecipeEntity, RecipeModel>().ForMember(dto => dto.Ingredients, opt => opt.MapFrom(x => x.IngredientRecipes.Select(y => y.Ingredient).ToList()));
                cfg.CreateMap<RecipeModel, RecipeEntity>();
                cfg.CreateMap<RecipeEntity, RecipeListModel>();
                cfg.CreateMap<AuthorModel, AuthorsEntity>();

            });

            return config;
        }

        public List<RecipeListModel> MapRecipeEntityListToRecipeModelList()
        {
            var config = new Mapper(MapperConfiguration());
            var recipeEntities = _recipeRepository.GetAll();
            return config.Map<List<RecipeListModel>>(recipeEntities);
        }
        public RecipeModel MapRecipeEntityToRecipeModel(RecipeEntity recipeEntity)
        {
            var config = new Mapper(MapperConfiguration());
            return config.Map<RecipeModel>(recipeEntity);
        }

        public RecipeEntity MapRecipeModelToRecipeEntity(RecipeModel recipeModel)
        {
            var config = new Mapper(MapperConfiguration());
            return config.Map<RecipeEntity>(recipeModel);
        }
    }
}
