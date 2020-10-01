using AutoMapper;
using Cookbook.BL.Models.Ingredient;
using Cookbook.DAL.Entities;
using Cookbook.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.MappersFile
{
    public class IngredientMapper : Profile
    {
        private readonly IngredientRepository _ingredientRepository = new IngredientRepository();
        private readonly IMapper _mapper;


        public IngredientMapper()
        {

        }
        public IngredientMapper(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IngredientEntity, IngredientModel>();
                cfg.CreateMap<IngredientModel, IngredientEntity>();

            });

            return config;
        }
        public List<IngredientListModel> MapIngredientEntityListToIngredientModelList()
        {
            var config = new Mapper(MapperConfiguration());
            var ingredientEntities = _ingredientRepository.GetAll();
            return config.Map<List<IngredientListModel>>(ingredientEntities);
        }
        public IngredientModel MapIngredientEntityToIngredientModel(IngredientEntity ingredientEntity)
        {
            var config = new Mapper(MapperConfiguration());
            return config.Map<IngredientModel>(ingredientEntity);
        }

        public IngredientEntity MapIngredientModelToIngredientEntity(IngredientModel ingredientModel)
        {
            var config = new Mapper(MapperConfiguration());
            return config.Map<IngredientEntity>(ingredientModel);
        }
    }
}
