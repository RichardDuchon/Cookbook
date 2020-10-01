using System;
using Cookbook.BL.Models;
using System.Collections.Generic;
using Cookbook.DAL.Repository;
using Cookbook.DAL.Entities;
using Cookbook.BL.MappersFile;
using Cookbook.BL.Facades;
using Cookbook.BL.Models.Recipe;

namespace Cookbook.App
{
    class Program
    {

        static void Main(string[] args)
        {
            List<RecipeListModel> recipeNameModel = new List<RecipeListModel> { new RecipeListModel() { RecipeName = "pes" }, new RecipeListModel() { RecipeName = "kocka" } };

            AuthorModel authorModel = new AuthorModel
            {
                AuthorName = "Bubu",
                Email = "repo",
                Recipes = recipeNameModel
            };

            AuthorModel pepa = new AuthorModel
            { 
                Id = 3
            };

            //AuthorRepository authorRepository = new AuthorRepository();
            //authorRepository.Add(authorModel);

            AuthorFacade authorFacade = new AuthorFacade();
            var pes = authorFacade.GetById(2);



            foreach(var i in authorFacade.GetAll())
            {
                Console.WriteLine(i.AuthorName);
            }


            Console.WriteLine(pes.AuthorName);

            Console.WriteLine("pes");


        }
    }
}
