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

        [HttpGet("GetAll", Name = "GetAll")]
        public IEnumerable<Category> CategoriesGetAllService()
        {
            var lista = _categoriesRepoService.GetAll();
            var result = lista.Result.ToList();
            return result;
        }

        [HttpGet("GetById", Name = "sGetById")]
        public IEnumerable<Category> CategoriesGetByIdService(string id)
        {
            var lista = _categoriesRepoService.GetById(id);
            var result = lista.Result.ToList();
            return result;
        }

        [HttpGet("GetByName", Name = "GetByName")]
        public IEnumerable<Category> CategoriesGetByNameService(string name)
        {
            var lista = _categoriesRepoService.GetByName(name);
            var result = lista.Result.ToList();
            return result;
        }

        [HttpGet("GetByParent", Name = "GetByParent")]
        public IEnumerable<Category> CategoriesGetByParentService(string name)
        {
            var lista = _categoriesRepoService.GetByParent(name);
            var result = lista.Result.ToList();
            return result;
        }

        [HttpPost("AddOne", Name = "AddOne")]
        public Category CategoriesAddOneService(string name, string? parent)
        {
            return _categoriesRepoService.AddOne(name, parent!).Result;
        }

        [HttpPut ("Update", Name = "Update")]
        public Category CategoriesUpdateService(string categoryId, string name, string? parent)
        {
            return _categoriesRepoService.Update(categoryId, name, parent).Result;
        }

        [HttpPut("Deactivate", Name = "Deactivate")]
        public string CategoriesDeactivateService(string categoryId)
        {
            _categoriesRepoService.Deactivate(categoryId);
            return "Registro desativado com sucesso";
        }

        [HttpDelete("Delete", Name = "Delete")]
        public string CategoriesDeleteService(string categoryId)
        {
            _categoriesRepoService.Delete(categoryId);
            return "Registro desatexcluidoivado com sucesso";
        }
    }
}
