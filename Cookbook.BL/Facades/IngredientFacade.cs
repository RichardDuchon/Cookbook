using Cookbook.BL.MappersFile;
using Cookbook.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Facades
{
    class IngredientFacade
    {
        private readonly IngredientRepository _ingredientRepository = new IngredientRepository();
        private readonly IngredientMapper _ingredientMapper = new IngredientMapper();

        //public void Delete(AuthorModel obj)
        //{
        //    var author = authorEntityToAuthorModel.MapAuthorModelToAuthorEntity(obj);
        //    _authorRepository.Delete(author);
        //}

        //public List<AuthorListModel> GetAll()
        //{
        //    var authorList = _authorRepository.GetAll();

        //    return authorEntityToAuthorModel.MapAuthorEntityListToAuthorModelList();
        //}

        //public AuthorModel GetById(int id)
        //{
        //    var author = _authorRepository.GetById(id);

        //    return authorEntityToAuthorModel.MapAuthorEntityToAuthorModel(author);
        //}

    }
}
