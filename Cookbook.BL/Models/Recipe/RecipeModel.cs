using Cookbook.BL.Models.Base;
using Cookbook.BL.Models.Ingredient;
using Cookbook.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Models
{
    public class RecipeModel : ModelBase
    {
        public string RecipeName { get; set; }
        public DateTime CreateDate { get; set; }
        //public ICollection<IngredientRecipeEntity> IngredientRecipes { get; set; }
        public ICollection<IngredientModel> Ingredients { get; set; }
        public string PreparationProcess { get; set; }
        public Categories Category { get; set; }
        public int AuthorId { get; set; }
        public AuthorModel Author { get; set; }
        public int TimeToPrepareInMinits { get; set; }
        public int TimeToBakeAndCookInMinits { get; set; }
        public int NumberOfServings { get; set; }
        public CookingDifficulties CookingDifficulty { get; set; }
    }
}
