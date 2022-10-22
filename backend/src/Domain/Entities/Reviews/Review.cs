
namespace Domain.Entities.Reviews
{
    public class Review
    {
        public Review(string userId, string recipeID, string comment, int stars)
        {
            UserId = userId;
            RecipeId = recipeID;
            Comment = comment;
            Stars = stars;
            Date = DateTime.Now;
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }
        public string UserId { get; private set; }
        public string RecipeId { get; private set; }
        public DateTime Date { get; private set; } 
        public string Comment { get; private set; }
        public int Stars { get; private set; }
    }
}
