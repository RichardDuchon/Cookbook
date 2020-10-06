using Cookbook.DAL.Entities.Base;

namespace Cookbook.DAL.Entities
{
    public class ReviewEntity : BaseIdEntity
    {
        public int AuthorId { get; set; }
        public virtual AuthorsEntity Author { get; set; }
        public string TextOfReview { get; set; }
        public int Score { get; set; }
    }
}
