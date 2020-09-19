using Cookbook.DAL.Entities.Base;

namespace Cookbook.DAL
{
    public class ReviewEntity : BaseIdEntity
    {
        public AuthorsEntity Author { get; set; }
        public string TextOfReview { get; set; }
        public int Score { get; set; }
    }
}
