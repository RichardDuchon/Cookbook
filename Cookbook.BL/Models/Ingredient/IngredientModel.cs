using Cookbook.BL.Models.Base;
using Cookbook.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Models.Ingredient
{
    
    public class IngredientModel : ModelBase
    {
        public string IngredientName { get; set; }
        public string IngredientDescription { get; set; }
        public ICollection<RecipeModel> Recipes { get; set; }
    }
}
