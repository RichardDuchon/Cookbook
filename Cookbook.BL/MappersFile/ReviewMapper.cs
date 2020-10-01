using AutoMapper;
using Cookbook.BL.Models.Review;
using Cookbook.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.MappersFile
{
    public class ReviewMapper : Profile
    {

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

        public ReviewEntity MapReviewModelToReviewEntity(ReviewModel reviewModel)
        {
            var config = new Mapper(MapperConfiguration());
            return config.Map<ReviewEntity>(reviewModel);
        }
    }
}
