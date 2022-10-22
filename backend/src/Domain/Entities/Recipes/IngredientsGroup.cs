
namespace Domain.Entities.Recipes
{
    public class IngredientsGroup
    {
        public IngredientsGroup()
        {

        }


        public string GroupName { get; private set; }
        public IList<Ingredient> Ingredients { get; private set; }
    }
}
