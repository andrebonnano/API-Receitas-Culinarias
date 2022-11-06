using Application.Interfaces;
using Application.Services;
using Domain.Entities.Recipes;
using Infra.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {

        private readonly ICategoriesRepoService _categoriesRepoService;

        public CategoriesController(ICategoriesRepoService categoriesRepoService)
        {
            _categoriesRepoService = categoriesRepoService;            
        }

        [HttpGet("get", Name = "Gett All")]
        public IEnumerable<Category> CategoriesGetAllService()
        {
            var lista = _categoriesRepoService.GetAll();
            var result = lista.Result.ToList();
            return result;
        }

        [HttpGet("getId/{id}/", Name = "Get by id")]
        public IEnumerable<Category> CategoriesGetByIdService(string id)
        {
            var lista = _categoriesRepoService.GetById(id);
            var result = lista.Result.ToList();
            return result;
        }

        [HttpGet("getName/{name}/", Name = "Get by name")]
        public IEnumerable<Category> CategoriesGetByNameService(string name)
        {
            var lista = _categoriesRepoService.GetByName(name);
            var result = lista.Result.ToList();
            return result;
        }

        [HttpGet("getParent/{parent}/", Name = "Get by parent")]
        public IEnumerable<Category> CategoriesGetByParentService(string parent)
        {
            var lista = _categoriesRepoService.GetByParent(parent);
            var result = lista.Result.ToList();
            return result;
        }

        [HttpPost("add", Name = "Post category")]
        public Category CategoriesAddOneService([FromQuery] string name, [FromQuery] string? parent)
        {
            return _categoriesRepoService.AddOne(name, parent!).Result;
        }

        [HttpPut ("edit/{id}", Name = "Update")]
        public Category CategoriesUpdateService(string id, string name, string? parent)
        {
            return _categoriesRepoService.Update(id, name, parent).Result;
        }

        [HttpPatch("deactivate/{id}", Name = "Deactivate")]
        public string CategoriesDeactivateService(string id)
        {
            _categoriesRepoService.Deactivate(id);
            return "Registro desativado com sucesso";
        }

        [HttpDelete("delete/{id}", Name = "Delete")]
        public async Task<IActionResult> CategoriesDeleteService(string id)
        {
            await _categoriesRepoService.Delete(id);
            return StatusCode(200, "Registro excluido");
        }
    }
}
