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
        public Categories DifficultyCategory { get; set; }
        public AuthorsEntity Author { get; set; }
        public int TimeToPrepareInMinits { get; set; }
        public int TimeToBakeAndCookInMinits { get; set; }
        public int NumberOfServings { get; set; }
        public NutritionalValuesEntity NutritionalValuesEntity { get; set; }
        public CookingDifficulties CookingDifficulty { get; set; }

        public virtual int CookingDifficultiesId
        {
            get
            {
                return (int)this.CookingDifficulty;
            }
            set
            {
                CookingDifficulty = (CookingDifficulties)value;
            }
        }

        public virtual int CategoryId
        {
            get
            {
                return (int)this.DifficultyCategory;
            }

            set
            {
                DifficultyCategory = (Categories)value;
            }
        }
    }

    public enum Categories
    {
        Pečení = 1,
        Vaření = 2,
        Dušení = 3,
        Smažení = 4
    }

    public enum CookingDifficulties
    {
        Easy = 1,
        Medium = 2,
        Hard = 3,
        Professional = 4
    }
}
