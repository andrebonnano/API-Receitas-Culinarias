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

        private readonly ICategoriesGetAllService _categoriesGetAllService;

        public CategoriesController(ICategoriesGetAllService categoriesGetAllService)
        {
            _categoriesGetAllService = categoriesGetAllService;            
        }

        [HttpGet("GetAllCategories", Name = "GetAllCategories")]
        public IEnumerable<Category> CategoriesGetAllService()
        {
            var lista = _categoriesGetAllService.ListAll();
            var result = lista.Result.ToList();
            return result;
        }
    }
}
