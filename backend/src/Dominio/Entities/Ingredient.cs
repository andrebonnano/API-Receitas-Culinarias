using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ingredient
    {
        public Ingredient(string name, double qty, string unity)
        {
            Name = name;
            Qty = qty;
            Unity = unity;
        }

        public string Name { get; private set; }
        public double Qty { get; private set; }
        public string Unity { get; private set; }
    }
}
