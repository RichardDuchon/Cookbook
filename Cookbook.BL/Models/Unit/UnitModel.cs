using Cookbook.BL.Models.Base;
using Cookbook.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Models.Unit
{
    public class UnitModel : ModelBase
    {
        public Units Unit { get; set; }
        public int Quantity { get; set; }
    }
}
