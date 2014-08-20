using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreServices.IModels;
using ServiceStack;
using ServiceStack.ServiceHost;

namespace RestServices.QuestionsWebService.RequestDTO
{
    [Api(Description = "Создание вопроса")]
    [Route("/questions/create", WebMethods.Create)]
    public class CreateQuestion : IReturn
    {
        [ApiMember(Description = "Идентификатор катигории")]
        public int CategoryId { get; set; }

        [ApiMember(Description = "Идентификатор статуса")]
        public int StatusId { get; set; }

        [ApiMember(Description = "Заголовок вопроса")]
        public string Title { get; set; }

        [ApiMember(Description = "Содержимое вопроса")]
        public string Content { get; set; }
    }
}