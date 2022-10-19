
namespace Domain.Entities.Recipes
{
    public class Category
    {
        public Category()
        {

        }

        public Category(string name)
        {
            Name = name;
        }

        public Category(string name, string parent)
        {
            Name = name;
            Parent = parent;
        }

        public string CategoryId { get; private set; } = Guid.NewGuid().ToString();
        public string Name { get; private set; }
        public string Parent { get; private set; }
    }
}
