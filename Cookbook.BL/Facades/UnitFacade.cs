using Cookbook.BL.MappersFile;
using Cookbook.BL.Models.Unit;
using Cookbook.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Facades
{
    public class UnitFacade
    {
        private readonly UnitRepository _unitRepository = new UnitRepository();
        private readonly UnitMapper _unitMapper = new UnitMapper();

        public void Delete(UnitModel obj)
        {
            var unit = _unitMapper.MapUnitModelToUnitEntity(obj);
            _unitRepository.Delete(unit);
        }

        public UnitModel GetById(int id)
        {
            var review = _unitRepository.GetById(id);

            return _unitMapper.MapUnitEntityToUnitModel(review);
        }

    }
}
