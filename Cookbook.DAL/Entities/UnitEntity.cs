using Cookbook.DAL.Entities.Base;

namespace Cookbook.DAL.Entities
{
    public class UnitEntity : BaseIdEntity
    {
        public int Unit { get; set; } //enum
        public int Quantity { get; set; }
    }

    public enum Units
    {

        Lžíce = 1,
        Kg = 2,
        g = 3,
        ml = 4,
        Kávová = 5
    }
}
