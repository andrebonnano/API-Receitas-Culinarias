
namespace Infra.Interfaces.Repositories
{
    public interface IRecipesRepo
    {
        #region == GET ==
        Task<IEnumerable<Recipe>> GetAll();
        Task<IEnumerable<Recipe>> GetByTitle(string title);
        Task<IEnumerable<Recipe>> GetById(string recipeId);
        Task<IEnumerable<Recipe>> GetByUserId(string userId);
        #endregion

        #region == POST ==
        Task AddOne(Recipe receita);
        Task AddMany(IEnumerable<Recipe> receitas);
        #endregion

        #region == UPDATE ==
        Task Update(string recipeId, Recipe receita);
        Task Desctivate(string recipeId);
        #endregion

        #region == DELETE ==
        Task Delete(string recipeId);
        #endregion
    }
}
