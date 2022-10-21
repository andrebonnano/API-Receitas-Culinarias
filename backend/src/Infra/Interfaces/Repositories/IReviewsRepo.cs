
namespace Infra.Interfaces.Repositories
{
    public interface IReviewsRepo
    {
        #region == GET ==
        Task<IEnumerable<Review>> GetByRecipeId(string recipeId);
        Task<IEnumerable<Review>> GetById(string categoryId);
        #endregion

        #region == POST ==
        Task AddOne(Review review);
        #endregion

        #region == UPDATE ==
        Task Update(string reviewId, Review review);
        Task Desctivate(string reviewId);
        #endregion

        #region == DELETE ==
        Task Delete(string reviewId);
        #endregion
    }
}
