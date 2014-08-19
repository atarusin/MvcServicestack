using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreServices.IModels;
using ServiceStack;

namespace RestServices.QuestionStatusesWebService.RequestDTO
{
    [Api(Description = "Получение вопроса")]
    [Route("/QuestionStatuses/{Id}", WebMethods.Get)]
    public class GetQuestionStatusById : IReturn<IQuestion>
    {
        [ApiMember(Description = "Идентификатор вопроса")]
        public int Id { get; set; }
    }
}