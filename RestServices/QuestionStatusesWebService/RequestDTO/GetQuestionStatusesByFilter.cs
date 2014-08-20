using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreServices.IModels;
using ServiceStack;
using ServiceStack.ServiceHost;

namespace RestServices.QuestionStatusesWebService.RequestDTO
{
    [Api(Description = "Получение списка статусов вопроса")]
    [Route("/questionStatuses", WebMethods.Get)]
    public class GetQuestionStatusesByFilter : IQuestionStatusFilter, IReturn<IEnumerable<IQuestionStatus>>
    {
        [ApiMember(Description = "Идентификатор статуса")]
        public int Id { get; set; }

        [ApiMember(Description = "Название статуса в именительном подеже")]
        public string Name { get; set; }

        [ApiMember(Description = "Название статуса в родительном подеже")]
        public string LName { get; set; }
    }
}