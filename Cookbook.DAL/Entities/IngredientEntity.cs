using Cookbook.DAL.Entities.Base;
using System.Collections.Generic;

namespace Cookbook.DAL.Entities
{
    public class IngredientEntity : BaseIdEntity
    {
        public string IngredientName { get; set; }
        public string IngredientDescription { get; set; }
        public virtual ICollection<IngredientRecipeEntity> IngredientRecipes { get; set; }


    }
}
