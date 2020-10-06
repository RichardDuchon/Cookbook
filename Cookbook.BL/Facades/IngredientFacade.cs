using Cookbook.BL.MappersFile;
using Cookbook.BL.Models.Ingredient;
using Cookbook.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Facades
{
    public class IngredientFacade
    {
        private readonly IngredientRepository _ingredientRepository = new IngredientRepository();
        private readonly IngredientMapper _ingredientMapper = new IngredientMapper();

        public void Delete(IngredientModel obj)
        {
            var author = _ingredientMapper.MapIngredientModelToIngredientEntity(obj);
            _ingredientRepository.Delete(author);
        }

        public List<IngredientListModel> GetAll()
        {
            return _ingredientMapper.MapIngredientEntityListToIngredientModelList();
        }

        public IngredientModel GetById(int id)
        {
            var author = _ingredientRepository.GetById(id);

            return _ingredientMapper.MapIngredientEntityToIngredientModel(author);
        }

        public void Add(IngredientModel ingredientModel)
        {
            var ingredientToAdd = _ingredientMapper.MapIngredientModelToIngredientEntity(ingredientModel);
            _ingredientRepository.Add(ingredientToAdd);
        }

        public void Update(IngredientModel ingredientModel)
        {
            var ingredientToUpdate = _ingredientMapper.MapIngredientModelToIngredientEntity(ingredientModel);
            _ingredientRepository.Update(ingredientToUpdate);
        }

    }
}
