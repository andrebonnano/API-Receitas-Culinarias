
namespace Domain.Entities.Recipes
{
    public class Recipe
    {
        public Recipe()
        {

        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public DateTime InstertDate { get; set; } = DateTime.Now;
        public string RecipeId { get; set; } = Guid.NewGuid().ToString();
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
