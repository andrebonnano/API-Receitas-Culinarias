
using System.ComponentModel.Design;

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

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string CategoryId { get; private set; } = Guid.NewGuid().ToString();
        public bool Active { get; private set; } = true;
        public string Name { get; private set; }
        public string Parent { get; private set; }
    }
}
