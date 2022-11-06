
using MongoDB.Bson.Serialization;

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

        public async Task<IEnumerable<Category>> GetByParent(string name)
        {
            var construtor = Builders<Category>.Filter;
            var condicao = construtor.Eq(c => c.Parent, name);
            var lista = await dbContext.Categories.Find(condicao).ToListAsync();
            return lista;
        }
        #endregion

        #region == POST ==
        public async Task<Category> AddOne(Category category)
        {
            //BsonClassMap.RegisterClassMap<Category>(cm => { cm.MapIdField("Id"); });
            await dbContext.Categories.InsertOneAsync(category);
            return category;
        }

        public async Task AddMany(IEnumerable<Category> categories)
        {
            await dbContext.Categories.InsertManyAsync(categories);
        }
        #endregion

        #region == UPDATE ==
        public async Task<Category> Update(string categoryId, Category category)
        {
            Category? originCategory = GetById(categoryId).Result.FirstOrDefault();
            category.Id = originCategory!.Id;
            category.CategoryId = categoryId;
            var construtor = Builders<Category>.Filter;
            var condicao = construtor.Eq(c => c.CategoryId, categoryId);
            await dbContext.Categories.ReplaceOneAsync(condicao, category);
            return category;
        }
        public async Task<Category> Deactivate(string categoryId)
        {
            var construtor = Builders<Category>.Filter;
            var condicao = construtor.Eq(c => c.CategoryId, categoryId);
            var alteracao = Builders<Category>.Update;
            var updater = alteracao.Set(r => r.Active, false);
            await dbContext.Categories.UpdateOneAsync(condicao, updater);
            return GetById(categoryId).Result.FirstOrDefault()!;
        }
        #endregion

        #region == DELETE ==
        public async Task<bool> Delete(string categoryId)
        {
            var filtro = Builders<Category>.Filter;
            var condicao = filtro.Eq(c => c.CategoryId, categoryId);
            var result = await dbContext.Categories.DeleteOneAsync(condicao);
            return result.DeletedCount == 1;
        }
        #endregion









        

        
    }
}
