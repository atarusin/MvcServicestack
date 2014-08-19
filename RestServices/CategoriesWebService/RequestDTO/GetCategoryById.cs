using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreServices.IModels;
using ServiceStack;

namespace RestServices.CategoriesWebService.RequestDTO
{
    [Api(Description = "Получение катигории вопросов")]
    [Route("/categories/{Id}", WebMethods.Get)]
    public class GetCategoryById : IReturn<ICategory>
    {
        [ApiMember(Description = "Идентификатор катигории вопросов")]
        public int Id { get; set; }
    }
}