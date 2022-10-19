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
    internal class GetRecipes
    {
        Context dbContext = new();

        public GetRecipes()
        {
        }

        public async Task GetByUser(string userId)
        {
            var Filtro = new BsonDocument
            {
                {"UserId", userId }
            };

            var lista = await dbContext.Recipes.Find(Filtro).ToListAsync();
            foreach (var item in lista)
            {
                Console.WriteLine(item.ToJson());
            }
            Console.WriteLine("Fim da lista");
        }

        public async Task<Recipe> GetById(string recipeId)
        {
            var Filtro = new BsonDocument
            {
                {"RecipeId", recipeId }
            };

            var lista = await dbContext.Recipes.Find(Filtro).FirstOrDefaultAsync();
            return lista;
        }

        public async Task GetByClassTitle(string title)
        {
            var construtor = Builders<Recipe>.Filter;
            var condicao = construtor.Eq(c => c.Title, title);

            var lista = await dbContext.Recipes.Find(condicao).ToListAsync();
            foreach (var item in lista)
            {
                Console.WriteLine(item.ToJson());
            }
            Console.WriteLine("Fim da lista");
        }

        public async Task GetAll()
        {
            var construtor = Builders<Recipe>.Filter;
            var condicao = construtor.Eq(c => c.Title, "andre");

            var lista = await dbContext.Recipes.Find(condicao).SortBy(s => s.Title).Limit(2).ToListAsync();
            foreach (var item in lista)
            {
                Console.WriteLine(item.ToJson());
            }
            Console.WriteLine("Fim da lista");
        }
    }
}
