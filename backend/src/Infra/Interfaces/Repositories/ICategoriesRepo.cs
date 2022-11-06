
namespace Infra.Interfaces.Repositories
{
    public interface ICategoriesRepo
    {
        #region == GET ==
        Task<IEnumerable<Category>> GetAll();
        Task<IEnumerable<Category>> GetByName(string name);
        Task<IEnumerable<Category>> GetById(string categoryId);
        Task<IEnumerable<Category>> GetByParent(string name);
        #endregion

        #region == POST ==
        Task<Category> AddOne(Category category);
        Task AddMany(IEnumerable<Category> categories);
        #endregion

        #region == UPDATE ==
        Task<Category> Update(string categoryId, Category category);
        Task<Category> Deactivate(string categoryId);
        #endregion

        #region == DELETE ==
        Task<bool> Delete(string categoryId);
        #endregion
    }
}
