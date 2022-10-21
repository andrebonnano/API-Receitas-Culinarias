using Infra.Interfaces.Repositories;

namespace Application.Services
{
    public class GetRecipeByIdService
    {
        IRecipesRepo _recipesRepo;

        public GetRecipeByIdService()
        {
            
        }

        public async Task<IEnumerable<Recipe>> Get(string id)
        {
            var receita = await _recipesRepo.GetById(id);
            var result = receita.ToList();
            return result;
        }
    }
}
