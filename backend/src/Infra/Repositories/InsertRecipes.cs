using Domain.Entities.Recipes;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Infra.Repositories
{
    public class InsertRecipes
    {
        public Recipe? Receita { get; set; }
        public IList<Recipe>? Receitas { get; set; }

        Context dbContext = new();

        public InsertRecipes(IList<Recipe> receitas)
        {
            Receitas = receitas;
        }

        public InsertRecipes(Recipe receita)
        {
            Receita = receita;
        }


        public async Task SaveOne()
        {
            await dbContext.Recipes.InsertOneAsync(Receita);
            Console.WriteLine("Documento inserido.");
        }

        public async Task SaveMany()
        {
            await dbContext.Recipes.InsertManyAsync(Receitas);
            Console.WriteLine("Documentos inseridos.");
        }
    }
}
