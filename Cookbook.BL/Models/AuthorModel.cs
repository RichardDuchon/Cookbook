using Cookbook.BL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Models
{
    class AuthorModel : ModelBase
    {
        public string AuthorName { get; set; }
        public string Email { get; set; }
        //public ICollection<> Recipes { get; set; } namapovaný Recepty 

    }
}
