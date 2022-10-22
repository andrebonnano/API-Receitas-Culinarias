using Domain.Entities.Recipes;
using Microsoft.AspNetCore.Mvc;
using Application.Services;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {

        [HttpGet("GetRecipeById", Name = "GetRecipeById")]
        public Recipe GetRecipeById(string recipeId)
        {
            string RecipeId = recipeId;
            var recipe = new RecipesRepoService();
            var result = recipe.Get(RecipeId).Result.FirstOrDefault();
            return result;
        }

        [HttpGet("GetRecipesByCategoryId", Name = "GetRecipesByCategoryId")]
        public IList<Recipe> GetRecipesByCategoryId(string categoryId)
        {
            Recipe receita = new Recipe();
            receita.Title = "Nome da Receita";
            var receitas = new List<Recipe> { receita };
            return receitas;
        }

        [HttpPost("PostNewRecipe", Name = "PostNewRecipe")]
        public bool PostNewRecipe(Recipe recipe)
        {
            return true;
        }

        [HttpPut("UpdateRecipe", Name = "UpdateRecipe")]
        public bool UpdateRecipe(string recipeId, Recipe recipe)
        {
            return true;
        }
    }
}
