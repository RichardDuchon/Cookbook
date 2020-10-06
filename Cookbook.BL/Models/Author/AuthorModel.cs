using Cookbook.BL.Models.Base;
using Cookbook.BL.Models.Recipe;
using Cookbook.BL.Models.Review;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Models
{
    public class AuthorModel : ModelBase
    {
        public string AuthorName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<RecipeListModel> Recipes { get; set; }
        public virtual ICollection<ReviewModel> Reviews { get; set; }


    }
}
