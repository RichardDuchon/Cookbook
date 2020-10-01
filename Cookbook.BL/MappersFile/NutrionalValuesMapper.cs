using AutoMapper;
using Cookbook.BL.Models;
using Cookbook.BL.Models.NutrionalValues;
using Cookbook.DAL.Entities;
using Cookbook.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.MappersFile
{
    public class NutrionalValuesMapper : Profile
    {

        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<NutrionalValuesModel, NutritionalValuesEntity>();
                cfg.CreateMap<NutritionalValuesEntity, NutrionalValuesModel>();
            });

            return config;
        }

        public NutrionalValuesModel MapRecipeEntityToRecipeModel(NutritionalValuesEntity nutrionalValuesEntity)
        {
            var config = new Mapper(MapperConfiguration());
            return config.Map<NutrionalValuesModel>(nutrionalValuesEntity);
        }

        public NutritionalValuesEntity MapRecipeModelToRecipeEntity(NutrionalValuesModel nutrionalValuesModel)
        {
            var config = new Mapper(MapperConfiguration());
            return config.Map<NutritionalValuesEntity>(nutrionalValuesModel);
        }
    }
}
