using Cookbook.DAL.Entities.Base;
using System.Collections.Generic;

namespace Cookbook.DAL.Entities
{
    public class IngredientEntity : BaseIdEntity
    {
        public string IngredientName { get; set; }
        public ICollection<IngredientRecipeEntity> IngredientRecipes { get; set; }


    }
}
