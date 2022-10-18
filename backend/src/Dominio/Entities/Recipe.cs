using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Recipe
    {

        public Recipe()
        {

        }

        public Guid UserId { get; set; }
        public DateTime InstertDate { get; set; } = DateTime.Now;
        public Guid RecipeId { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public IList<Category> Categories { get; set; }
        public IList<string> Tags { get; set; }
        public double PreparationTime { get; set; }
        public int Servings { get; set; }
        public IList<IngredientsGroup> Ingredients { get; set; }
        public IList<PrepareGroup> Prepare { get; set; }
        public string Description { get; set; }
        public IList<string> Images { get; set; }
        public IList<string> Videos { get; set; }
        public IList<Review> Reviews { get; set; }

    }

}
