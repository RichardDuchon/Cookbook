using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Models.Review
{
    public class ReviewModel
    {
        public AuthorModel Author { get; set; }
        public string TextOfReview { get; set; }
        public int Score { get; set; }

    }
}
