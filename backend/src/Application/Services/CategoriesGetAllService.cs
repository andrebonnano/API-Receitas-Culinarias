using Application.Interfaces;
using Infra.Interfaces.Repositories;

namespace Application.Services
{
    public class CategoriesGetAllService : ICategoriesGetAllService
    {
        #region == ATRIBUTOS ==
        ICategoriesRepo _categoriesRepo;
        #endregion


        #region == CONSTRUTOR ==
        public CategoriesGetAllService(ICategoriesRepo categoriesRepo)
        {
            _categoriesRepo = categoriesRepo;
        }
        #endregion

        #region == METODOS ==
        public async Task<IEnumerable<Category>> ListAll()
        {
            var lista = await _categoriesRepo.GetAll();
            var result = lista.ToList();
            return result;
        }
        #endregion
    }
}
