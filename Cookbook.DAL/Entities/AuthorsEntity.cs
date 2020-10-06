using Cookbook.DAL.Entities.Base;
using System.Collections.Generic;

namespace Cookbook.DAL.Entities
{
    public class AuthorsEntity : BaseIdEntity
    {
        public string AuthorName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<RecipeEntity> Recipes { get; set; }
        public virtual ICollection<ReviewEntity> Reviews { get; set; }

    }
}
