using Domain.Entities.Recipes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    internal class RemoveRecipe
    {
        Context dbContext = new();
        public string SentRecipeId { get; set; }


        public RemoveRecipe(string recipeId)
        {
            SentRecipeId = recipeId;
        }

        public async Task Execute()
        {
            var filtro = Builders<Recipe>.Filter;
            var condicao = filtro.Eq(c => c.RecipeId, SentRecipeId);

            await dbContext.Recipes.DeleteOneAsync(condicao);
        }
    }
}
