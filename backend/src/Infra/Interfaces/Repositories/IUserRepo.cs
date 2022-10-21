using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Interfaces.Repositories
{
    internal interface IUserRepo
    {
        #region == GET ==
        Task<IEnumerable<Recipe>> GetById(string recipeId);
        Task<IEnumerable<Recipe>> GetByName(string userId);
        #endregion

        #region == POST ==
        Task AddOne(Recipe receita);
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
