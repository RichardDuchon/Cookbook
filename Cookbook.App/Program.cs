using System;
using Cookbook.BL.Models;
using System.Collections.Generic;
using Cookbook.DAL.Repository;
using Cookbook.DAL.Entities;
using Cookbook.BL.MappersFile;
using Cookbook.BL.Facades;
using Cookbook.BL.Models.Recipe;
using System.Linq;
using Cookbook.BL.Models.Ingredient;

namespace Cookbook.App
{
    class Program
    {

        static void Main(string[] args)
        {
            IngredientFacade ingredientFacade = new IngredientFacade();


            List<IngredientModel> ingredientModels = new List<IngredientModel>();
            ingredientModels.Add(ingredientFacade.GetById(1));


            RecipeFacade recipeFacade = new RecipeFacade();

            RecipeModel recipeModel = new RecipeModel
            {
                CookingDifficulty = CookingDifficulties.Hard,
                CreateDate = DateTime.Now,
                Category = Categories.Dušení,
                NumberOfServings = 5,
                PreparationProcess = "Uvařte pokapte snězte",
                RecipeName = "Bábovka",
                TimeToBakeAndCookInMinits = 50,
                TimeToPrepareInMinits = 70,
                Ingredients = ingredientModels,
                AuthorId = 1,
            };

            Console.WriteLine(recipeFacade.GetById(2).CookingDifficulty);
        }
    }
}
