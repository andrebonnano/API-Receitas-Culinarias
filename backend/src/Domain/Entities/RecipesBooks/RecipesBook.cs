
namespace Domain.Entities.RecipesBooks
{
    public class RecipesBook
    {
        public RecipesBook(string userId)
        {
            UserId = userId;
            List<string> Receitas = new List<string>();
        }

        public string Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Receitas { get; set; }

        public bool AddRecipe(string recipeId)
        {
            Receitas.Append(recipeId);
            return true;
        }

        public bool RemoveRecipe(string recipeId)
        {
            var itemToRemove = Receitas.Single(r => r.Equals(recipeId));

            if (itemToRemove != null)
                Receitas.Remove(itemToRemove);
            
            return true;
        }
    }
}
