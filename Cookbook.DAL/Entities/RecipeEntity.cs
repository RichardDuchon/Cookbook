using Cookbook.DAL.Entities.Base;
using System;
using System.Collections.Generic;

namespace Cookbook.DAL.Entities
{
    public class RecipeEntity : BaseIdEntity
    {
        public string RecipeName { get; set; }
        public DateTime CreateDate { get; set; }
        public ICollection<IngredientRecipeEntity> IngredientRecipes { get; set; }
        public string PreparationProcess { get; set; }
        public int Category { get; set; } //enum
        public AuthorsEntity Author { get; set; }
        public int TimeToPrepareInMinits { get; set; }
        public int TimeToBakeAndCookInMinits { get; set; }
        public int NumberOfServings { get; set; }
        public int Difficulty { get; set; }//enum
    }

    public enum Categories
    {
        Pečení = 1,
        Vaření = 2,
        Dušení = 3,
        Smažení = 4
    }

    public enum CookingDifficulty
    {
        Easy = 1,
        Medium = 2,
        Hard = 3,
        Professional = 4
    }
}
