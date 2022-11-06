
namespace Application.Services
{
    public class CategoriesRepoService : ICategoriesRepoService
    {
        #region == ATRIBUTOS ==
        ICategoriesRepo _categoriesRepo;

        StringValidation stringValidation = new();
        #endregion


        #region == CONSTRUTOR ==
        public CategoriesRepoService(ICategoriesRepo categoriesRepo)
        {
            _categoriesRepo = categoriesRepo;
        }
        #endregion


        #region == METODOS ==
        public async Task<IEnumerable<Category>> GetAll()
        {
            var lista = await _categoriesRepo.GetAll();
            var result = lista.ToList();
            return result;
        }

        public async Task<IEnumerable<Category>> GetByName(string name)
        {
            var lista = await _categoriesRepo.GetByName(name);
            var result = lista.ToList();
            return result;
        }

        public async Task<IEnumerable<Category>> GetById(string id)
        {

            var idOk = stringValidation.GuidValidator(id);

            var lista = await _categoriesRepo.GetById(idOk);
            var result = lista.ToList();
            return result;
        }

        public async Task<IEnumerable<Category>> GetByParent(string name)
        {
            var lista = await _categoriesRepo.GetByParent(name);
            var result = lista.ToList();
            return result;
        }

        public async Task<Category> AddOne(string name, string parent)
        {
            var nameOk = stringValidation.TitleNameValidator(name);

            Category category = new(nameOk);

            if (parent != null)
            {
                var titleOk = stringValidation.TitleNameValidator(parent);
                category.Parent = titleOk;
            }

            return await _categoriesRepo.AddOne(category);
        }

        public async Task AddMany(string[] names, string[] parents)
        {
            int total = names.Length;
            List<Category> categories = new();
            foreach (var name in names)
            {
                categories.Add(new Category(name, parents[name.Count()]));
            }
            await _categoriesRepo.AddMany(categories);
        }

        public async Task<Category> Update(string categoryId, string name, string? parent)
        {
            Category category = new(name, parent!);
            category.CategoryId = categoryId;
            var result =  await _categoriesRepo.Update(categoryId, category);
            return result;
        }

        public async Task<Category> Deactivate(string categoryId)
        {
            var category = await _categoriesRepo.Deactivate(categoryId);
            return category;
        }

        public async Task<bool> Delete(string categoryId)
        {
            await _categoriesRepo.Delete(categoryId);
            return true;
        }

        #endregion
    }
}
