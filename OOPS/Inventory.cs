using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Inventory
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public Inventory(string Name, double Weight, double Price)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.Price = Price;
        }
    }
}
