using Cookbook.BL.MappersFile;
using Cookbook.BL.Models.Review;
using Cookbook.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Facades
{
    public class ReviewFacade
    {
        private readonly ReviewRepository _reviewRepository = new ReviewRepository();
        private readonly ReviewMapper _reviewMapper = new ReviewMapper();

        public void Delete(ReviewModel obj)
        {
            var recipe = _reviewMapper.MapReviewModelToReviewEntity(obj);
            _reviewRepository.Delete(recipe);
        }

        public void Add(ReviewModel obj)
        {
            var itemToAdd = _reviewMapper.MapReviewModelToReviewEntity(obj);
            _reviewRepository.Add(itemToAdd);
        }
        public List<ReviewModel> GetAllModels()
        {
            return _reviewMapper.MapListOfReviewEntityToReviewModel();
        }
        public ReviewModel GetById(int id)
        {
            var review = _reviewRepository.GetById(id);

            return _reviewMapper.MapReviewEntityToReviewModel(review);
        }
    }
}
