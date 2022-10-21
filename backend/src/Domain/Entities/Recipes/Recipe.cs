
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
        public bool Active { get; private set; } = true;
        public string Title { get; set; }
        public List<Category> Categories { get; set; }
        public List<string> Tags { get; set; }
        public double PreparationTime { get; set; }
        public int Servings { get; set; }
        public List<IngredientsGroup> Ingredients { get; set; }
        public List<PrepareGroup> Prepare { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public List<string> Videos { get; set; }
        public List<Review> Reviews { get; set; }


        public bool AddTags(List<string> tags)
        {
            Tags.AddRange(tags);
            return true;
        }

        public bool RemoveTags(string tag)
        {
            var itemToRemove = Tags.Single(r => r.Equals(tag));

            if (itemToRemove != null)
                Tags.Remove(itemToRemove);

            return true;
        }

        public bool AddImages(List<string> images)
        {
            Images.AddRange(images);
            return true;
        }

        public bool RemoveImage(string image)
        {
            var itemToRemove = Tags.Single(r => r.Equals(image));

            if (itemToRemove != null)
                Images.Remove(itemToRemove);

            return true;
        }

        public bool AddVideos(List<string> videos)
        {
            Videos.AddRange(videos);
            return true;
        }

        public bool RemoveVideo(string video)
        {
            var itemToRemove = Tags.Single(r => r.Equals(video));

            if (Videos != null)
                Images.Remove(itemToRemove);

            return true;
        }

        public bool AddReview(Review review)
        {
            Reviews.Add(review);
            return true;
        }

        public bool RemoveReview(Review review)
        {
            Reviews.Remove(review);
            return true;
        }
    }

}
