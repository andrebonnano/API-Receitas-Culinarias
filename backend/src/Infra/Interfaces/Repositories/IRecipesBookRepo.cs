
namespace Infra.Interfaces.Repositories
{
    public interface IRecipesBookRepo
    {
        #region == GET ==
        Task<IEnumerable<RecipesBook>> GetAllByUserId(string userId);
        Task<IEnumerable<RecipesBook>> GetOneById(string bookId);
        #endregion

        #region == POST ==
        Task AddOne(RecipesBook book);
        #endregion

        #region == UPDATE ==
        Task Update(string bookId, RecipesBook book);
        Task Desctivate(string bookId);
        #endregion

        #region == DELETE ==
        Task Delete(string bookId);
        #endregion
    }
}
