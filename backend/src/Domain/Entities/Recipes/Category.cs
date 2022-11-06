
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Recipes
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

        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string CategoryId { get; set; } = Guid.NewGuid().ToString();
        
        public bool Active { get;  set; } = true;

        public string Name { get;  set; }
        
        public string? Parent { get;  set; }
    }
}
