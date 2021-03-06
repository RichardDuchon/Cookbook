﻿using Cookbook.DAL.Entities.Base;

namespace Cookbook.DAL.Entities
{
    public class UnitEntity : BaseIdEntity
    {
        public int Quantity { get; set; }

        public Units Unit { get; set; }
        public virtual int UnitId
        {
            get
            {
                return (int)this.Unit;
            }
            set
            {
                Unit = (Units)value;
            }
        }
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
