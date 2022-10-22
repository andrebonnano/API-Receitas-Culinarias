
namespace Domain.Entities.Recipes
{
    public class Ingredient
    {
        public Ingredient()
        {

        }

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
