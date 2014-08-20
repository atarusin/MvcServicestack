using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreServices.IModels;
using ServiceStack;
using ServiceStack.ServiceHost;

namespace RestServices.CategoriesWebService.RequestDTO
{
    [Api(Description = "Получение катигории вопросов")]
    [Route("/categories/create", WebMethods.Create)]
    public class CreateCategory : IReturn
    {
        [ApiMember(Description = "Название катигории вопросов")]
        public string Title { get; set; }
    }
}