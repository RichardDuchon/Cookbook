using Cookbook.BL.Models.Base;
using Cookbook.BL.Models.Recipe;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Models
{
    public class AuthorModel : ModelBase
    {
        public string AuthorName { get; set; }
        public string Email { get; set; }
        public ICollection<RecipeListModel> Recipes { get; set; } 

    }
}
