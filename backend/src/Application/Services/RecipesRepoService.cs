
namespace Application.Services
{
    public class RecipesRepoService
    {
        IRecipesRepo _recipesRepo;

        public async Task<IEnumerable<Recipe>> Get(string id)
        {
            var receita = await _recipesRepo.GetById(id);
            var result = receita.ToList();
            return result;
        }
    }
}
