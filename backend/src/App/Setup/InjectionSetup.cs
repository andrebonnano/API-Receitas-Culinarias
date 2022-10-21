using Application.Interfaces;
using Application.Services;
using Infra.Interfaces.Repositories;
using Infra.Repositories;

namespace Api.Setup
{
    public static class InjectionSetup
    {
        public static void SetupInjection (IServiceCollection services)
        {
            services.AddScoped<IRecipesRepo, RecipesRepo>();
            services.AddScoped<ICategoriesRepo, CategoriesRepo>();
            services.AddScoped<ICategoriesGetAllService, CategoriesGetAllService>();
        }
    }
}
