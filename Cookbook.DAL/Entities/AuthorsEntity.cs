using Cookbook.DAL.Entities.Base;

namespace Cookbook.DAL.Entities
{
    public class AuthorsEntity : BaseIdEntity
    {
        public string AuthorName { get; set; }
        public string Email { get; set; }
    }
}
