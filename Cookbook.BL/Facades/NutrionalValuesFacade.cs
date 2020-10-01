using Cookbook.BL.MappersFile;
using Cookbook.BL.Models.NutrionalValues;
using Cookbook.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Facades
{
    public class NutrionalValuesFacade
    {
        private readonly NutrionalValuesRepository _nutrionalValuesRepository = new NutrionalValuesRepository();
        private readonly NutrionalValuesMapper  _nutrionalValuesMapper = new NutrionalValuesMapper();

        public void Delete(NutrionalValuesModel obj)
        {
            var recipe = _nutrionalValuesMapper.MapRecipeModelToRecipeEntity(obj);
            _nutrionalValuesRepository.Delete(recipe);
        }

        public NutrionalValuesModel GetById(int id)
        {
            var author = _nutrionalValuesRepository.GetById(id);

            return _nutrionalValuesMapper.MapRecipeEntityToRecipeModel(author);
        }
    }
}
