using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mappings
{
    internal class CategoriesMapping
    {
        public CategoriesMapping()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDto>());
            var mapper = new Mapper(config);

            //var category = mapper.Map<CategoryDto>(Category);
        }
    }
}
