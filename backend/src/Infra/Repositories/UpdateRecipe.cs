using Domain.Entities.Recipes;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    internal class UpdateRecipe
    {
        Context dbContext = new();
        public Recipe OriginalRecipe;
        public Recipe UpdatedRecipe { get; set; } = new Recipe();
        public string SentRecipeId { get; set; }

        public UpdateRecipe(string recipeId)
        {
            SentRecipeId = recipeId;

            GetRecipes receitas = new GetRecipes();
            OriginalRecipe = receitas.GetById(recipeId).Result;
            Console.WriteLine(OriginalRecipe.ToJson());
        }

        public async Task UpdateTitle(string title)
        {
            var filtro = Builders<Recipe>.Filter;
            var condicao = filtro.Eq(c => c.RecipeId, SentRecipeId);

            var alteracao = Builders<Recipe>.Update;
            var updater = alteracao
                .Set(s => s.Title, title);

            await dbContext.Recipes.UpdateOneAsync(condicao, updater);

            GetRecipes result = new GetRecipes();
            var Alterada = result.GetById(SentRecipeId).Result;
            Console.WriteLine(Alterada.ToJson());
        }

        public async Task UpdateObject(Recipe receita)
        {
            UpdatedRecipe = receita;

            var construtor = Builders<Recipe>.Filter;
            var condicao = construtor.Eq(c => c.RecipeId, SentRecipeId);

            await dbContext.Recipes.ReplaceOneAsync(condicao, UpdatedRecipe);

            GetRecipes result = new GetRecipes();
            var Alterada = result.GetById(UpdatedRecipe.RecipeId).Result;
            Console.WriteLine(Alterada.ToJson());
        }
    }
}
