using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Category
    {
        public Category(string name)
        {
            Name = name;
        }

        public Category(string name, string parent)
        {
            Name = name;
            Parent = parent;
        }

        public Guid CategoryId { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public string Parent { get; private set; }
    }
}
