
using Domain.Entities.Recipes;
using MongoDB.Driver;

namespace Infra.Repositories
{
    public class CategoriesRepo : ICategoriesRepo
    {
        Context dbContext = new();


        #region == GET ==
        public async Task<IEnumerable<Category>> GetAll()
        {
            var construtor = Builders<Category>.Filter;
            var condicao = construtor.Type(c => c.Name, BsonType.String);
            var lista = await dbContext.Categories.Find(condicao).ToListAsync();
            return lista;
        }

        public async Task<IEnumerable<Category>> GetByName(string name)
        {
            var construtor = Builders<Category>.Filter;
            var condicao = construtor.Eq(c => c.Name, name);
            var lista = await dbContext.Categories.Find(condicao).ToListAsync();
            return lista;
        }

        public async Task<IEnumerable<Category>> GetById(string categoryId)
        {
            var construtor = Builders<Category>.Filter;
            var condicao = construtor.Eq(c => c.CategoryId, categoryId);
            var lista = await dbContext.Categories.Find(condicao).ToListAsync();
            return lista;
        }
        #endregion

        #region == POST ==
        public async Task AddOne(Category category)
        {
            await dbContext.Categories.InsertOneAsync(category);
        }

        public async Task AddMany(IEnumerable<Category> categories)
        {
            await dbContext.Categories.InsertManyAsync(categories);
        }
        #endregion

        #region == UPDATE ==
        public async Task Update(string categoryId, Category category)
        {
            var construtor = Builders<Category>.Filter;
            var condicao = construtor.Eq(c => c.CategoryId, categoryId);
            await dbContext.Categories.ReplaceOneAsync(condicao, category);
        }
        public async Task Desctivate(string categoryId)
        {
            var construtor = Builders<Category>.Filter;
            var condicao = construtor.Eq(c => c.CategoryId, categoryId);
            var alteracao = Builders<Category>.Update;
            var updater = alteracao.Set(r => r.Active, false);
            await dbContext.Categories.UpdateOneAsync(condicao, updater);
        }
        #endregion

        #region == DELETE ==
        public async Task Delete(string categoryId)
        {
            var filtro = Builders<Category>.Filter;
            var condicao = filtro.Eq(c => c.CategoryId, categoryId);
            await dbContext.Categories.DeleteOneAsync(condicao);
        }
        #endregion









        

        
    }
}
