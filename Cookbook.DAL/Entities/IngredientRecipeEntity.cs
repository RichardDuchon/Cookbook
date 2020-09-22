using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.DAL.Entities
{
    public class IngredientRecipeEntity
    {
        public int IngredientId { get; set; }
        public IngredientEntity Ingredient { get; set; }

        public int RecipeId { get; set; }
        public RecipeEntity Recipe { get; set; }
    }
}
