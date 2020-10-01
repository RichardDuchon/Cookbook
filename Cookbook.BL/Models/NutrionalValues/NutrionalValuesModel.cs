using Cookbook.BL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Models.NutrionalValues
{
    public class NutrionalValuesModel : ModelBase
    {
        public string PortionSize { get; set; }
        public float EnergyValue { get; set; }
        public int Carbohydrates { get; set; }
        public int Fat { get; set; }
        public int Proteins { get; set; }
    }
}
