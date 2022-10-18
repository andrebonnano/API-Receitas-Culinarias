using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class IngredientsGroup
    {
        public string GroupName { get; private set; }
        public IList<Ingredient> Ingredients { get; private set; }
    }
}
