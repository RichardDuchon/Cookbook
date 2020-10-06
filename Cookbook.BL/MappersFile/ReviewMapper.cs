using AutoMapper;
using Cookbook.BL.Models.Review;
using Cookbook.DAL.Entities;
using Cookbook.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.MappersFile
{
    public class ReviewMapper : Profile
    {
        private readonly ReviewRepository _reviewRepository = new ReviewRepository();
        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ReviewModel, ReviewEntity>();
                cfg.CreateMap<ReviewEntity, ReviewModel>();
            });

            return config;
        }

        public ReviewModel MapReviewEntityToReviewModel(ReviewEntity reviewEntity)
        {
            var config = new Mapper(MapperConfiguration());
            return config.Map<ReviewModel>(reviewEntity);
        }
        public List<ReviewModel> MapListOfReviewEntityToReviewModel()
        {
            var config = new Mapper(MapperConfiguration());
            var reviewEntities = _reviewRepository.GetAll();
            return config.Map<List<ReviewModel>>(reviewEntities);
        }
        public ReviewEntity MapReviewModelToReviewEntity(ReviewModel reviewModel)
        {
            var config = new Mapper(MapperConfiguration());
            return config.Map<ReviewEntity>(reviewModel);
        }
    }
}
