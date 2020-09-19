using Cookbook.DAL.Entities.Base;

namespace Cookbook.DAL
{
    public class NutritionalValuesEntity : BaseIdEntity
    {
        public string PortionSize { get; set; }
        public float EnergyValue { get; set; }
        public int Carbohydrates { get; set; }
        public int Fat { get; set; }
        public int Proteins { get; set; }
    }
}
