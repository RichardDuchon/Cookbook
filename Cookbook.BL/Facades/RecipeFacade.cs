using Cookbook.BL.MappersFile;
using Cookbook.BL.Models;
using Cookbook.BL.Models.Recipe;
using Cookbook.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Facades
{
    class RecipeFacade
    {
        private readonly RecipeRepository _recipeRepository = new RecipeRepository();
        private readonly RecipeMapper _recipeMapper = new RecipeMapper();

        public void Delete(RecipeModel obj)
        {
            var recipe = _recipeMapper.MapRecipeModelToRecipeEntity(obj);
            _recipeRepository.Delete(recipe);
        }

        public List<RecipeListModel> GetAll()
        {
            return _recipeMapper.MapRecipeEntityListToRecipeModelList();
        }

        public RecipeModel GetById(int id)
        {
            var author = _recipeRepository.GetById(id);

            return _recipeMapper.MapRecipeEntityToRecipeModel(author);
        }
    }
}
