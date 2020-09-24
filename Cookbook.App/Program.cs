using System;
using Cookbook.DAL;
using Cookbook.BL;
using Cookbook.DAL.Entities;
using Cookbook.BL.Models;
using Cookbook.BL.Repository;
using Cookbook.BL.MappersFile;
using System.Collections.Generic;

namespace Cookbook.App
{
    class Program
    {

        static void Main(string[] args)
        {
            List<RecipeNameModel> recipeNameModel = new List<RecipeNameModel> { new RecipeNameModel() { RecipeName = "pes" }, new RecipeNameModel() { RecipeName = "kocka" } };


            AuthorModel authorModel = new AuthorModel
            {
                AuthorName = "Pepe",
                Email = "kos",
                Recipes = recipeNameModel
            };

            AuthorRepository authorRepository = new AuthorRepository(new DefaultDbContextFactory(), new Mappers());

            authorRepository.Add(authorModel);
            Console.WriteLine("pes");


        }
    }
}
