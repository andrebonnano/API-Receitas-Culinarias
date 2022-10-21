
namespace Infra.Interfaces.Repositories
{
    public interface ICategoriesRepo
    {
        #region == GET ==
        Task<IEnumerable<Category>> GetAll();
        Task<IEnumerable<Category>> GetByName(string name);
        Task<IEnumerable<Category>> GetById(string categoryId);
        #endregion

        #region == POST ==
        Task AddOne(Category category);
        Task AddMany(IEnumerable<Category> categories);
        #endregion

        #region == UPDATE ==
        Task Update(string categoryId, Category category);
        Task Desctivate(string categoryId);
        #endregion

        #region == DELETE ==
        Task Delete(string categoryId);
        #endregion
    }
}
