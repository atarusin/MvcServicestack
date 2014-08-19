using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreServices.IModels;
using ServiceStack;

namespace RestServices.CategoriesWebService.RequestDTO
{
    [Api(Description = "Получение списка катигорий вопросов")]
    [Route("/categories", WebMethods.Get)]
    public class GetCategoriesByFilter : ICategoryFilter, IReturn<IEnumerable<ICategory>>
    {
        [ApiMember(Description = "Идентификатор катигории вопросов")]
        public int Id { get; set; }

        [ApiMember(Description = "Название катигории вопросов")]
        public string Title { get; set; }
    }
}