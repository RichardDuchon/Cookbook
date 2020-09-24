using Cookbook.BL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Models
{
    public class AuthorModel : ModelBase
    {
        public string AuthorName { get; set; }
        public string Email { get; set; }
        public ICollection<RecipeNameModel> Recipes { get; set; } 

    }
}
