using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreServices.IModels;
using ServiceStack;
using ServiceStack.ServiceHost;

namespace RestServices.QuestionsWebService.RequestDTO
{
    [Api(Description = "Получение вопроса")]
    [Route("/Questions/{Id}", WebMethods.Get)]
    public class GetQuestionById : IReturn<IQuestion>
    {
        [ApiMember(Description = "Идентификатор вопроса")]
        public int Id { get; set; }
    }
}