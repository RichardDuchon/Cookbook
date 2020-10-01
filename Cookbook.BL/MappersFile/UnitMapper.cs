using AutoMapper;
using Cookbook.BL.Models.Unit;
using Cookbook.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.MappersFile
{
    public class UnitMapper : Profile
    {

        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UnitModel, UnitEntity>();
                cfg.CreateMap<UnitEntity, UnitModel>();
            });

            return config;
        }

        public UnitModel MapUnitEntityToUnitModel(UnitEntity unitEntity)
        {
            var config = new Mapper(MapperConfiguration());
            return config.Map<UnitModel>(unitEntity);
        }

        public UnitEntity MapUnitModelToUnitEntity(UnitModel unitModel)
        {
            var config = new Mapper(MapperConfiguration());
            return config.Map<UnitEntity>(unitModel);
        }
    }
}
