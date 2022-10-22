
namespace Application.Interfaces
{
    public interface ICategoriesRepoService
    {
        #region == GET ==
        Task<IEnumerable<Category>> GetAll();
        Task<IEnumerable<Category>> GetByName(string name);
        Task<IEnumerable<Category>> GetById(string categoryId);
        Task<IEnumerable<Category>> GetByParent(string name);
        #endregion

        #region == POST ==
        Task<Category> AddOne(string name, string parent);
        Task AddMany(string[] names, string[] parents);
        #endregion

        #region == UPDATE ==
        Task<Category> Update(string categoryId, string name, string? parent);
        Task Deactivate(string categoryId);
        #endregion

        #region == DELETE ==
        Task Delete(string categoryId);
        #endregion
    }
}
