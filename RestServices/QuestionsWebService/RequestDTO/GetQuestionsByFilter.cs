using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreServices.IModels;
using ServiceStack.ServiceHost;

namespace RestServices.QuestionsWebService.RequestDTO
{
    [Api(Description = "Получение списка вопросов")]
    [Route("/questions", WebMethods.Get)]
    public class GetQuestionsByFilter : IQuestionFilter, IReturn<IEnumerable<IQuestion>>
    {
        [ApiMember(Description = "Идентификатор вопроса")]
        public int Id { get; set; }

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