
namespace Infra.Repositories
{
    public class RecipesRepo : IRecipesRepo

    {
        Context dbContext = new();

        #region == GET ==
        public async Task<IEnumerable<Recipe>> GetAll()
        {
            var construtor = Builders<Recipe>.Filter;
            var condicao = construtor.Type(c => c.Title, BsonType.String);
            var lista = await dbContext.Recipes.Find(condicao).SortBy(s => s.Title).ToListAsync();
            return lista;
        }

        public async Task<IEnumerable<Recipe>> GetByTitle(string title)
        {
            var construtor = Builders<Recipe>.Filter;
            var condicao = construtor.Eq(c => c.Title, title);
            var lista = await dbContext.Recipes.Find(condicao).ToListAsync();
            return lista;
        }

        public async Task<IEnumerable<Recipe>> GetById(string recipeId)
        {
            var construtor = Builders<Recipe>.Filter;
            var condicao = construtor.Eq(c => c.RecipeId, recipeId);

            var lista = await dbContext.Recipes.Find(condicao).ToListAsync();
            return lista;
        }

        public async Task<IEnumerable<Recipe>> GetByUserId(string userId)
        {
            var construtor = Builders<Recipe>.Filter;
            var condicao = construtor.Eq(c => c.UserId, userId);

            var lista = await dbContext.Recipes.Find(condicao).ToListAsync();
            return lista;
        }
        #endregion

        #region == POST ==
        public async Task AddOne(Recipe receita)
        {
            await dbContext.Recipes.InsertOneAsync(receita);
        }

        public async Task AddMany(IEnumerable<Recipe> receitas)
        {
            await dbContext.Recipes.InsertManyAsync(receitas);
        }
        #endregion

        #region == UPDATE ==
        public async Task Update(string recipeId, Recipe receita)
        {
            var construtor = Builders<Recipe>.Filter;
            var condicao = construtor.Eq(c => c.RecipeId, recipeId);
            await dbContext.Recipes.ReplaceOneAsync(condicao, receita);
        }

        public async Task Desctivate(string recipeId)
        {
            var construtor = Builders<Recipe>.Filter;
            var condicao = construtor.Eq(c => c.RecipeId, recipeId);
            var alteracao = Builders<Recipe>.Update;
            var updater = alteracao.Set(r => r.Active, false);
            await dbContext.Recipes.UpdateOneAsync(condicao, updater);
        }
        #endregion

        #region == DELETE ==
        public async Task Delete(string recipeId)
        {
            var filtro = Builders<Recipe>.Filter;
            var condicao = filtro.Eq(c => c.RecipeId, recipeId);
            await dbContext.Recipes.DeleteOneAsync(condicao);
        }
        #endregion
    }
}
