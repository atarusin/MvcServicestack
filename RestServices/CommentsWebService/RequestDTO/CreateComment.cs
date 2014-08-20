using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreServices.IModels;
using ServiceStack;
using ServiceStack.ServiceHost;

namespace RestServices.CommentsWebService.RequestDTO
{
    [Api(Description = "Создание коментария к вопросу")]
    [Route("/сomments/create", WebMethods.Create)]
    public class CreateComment : IReturn
    {
        [ApiMember(Description = "Идентификатор вопроса")]
        public int QuestionId { get; set; }

        [ApiMember(Description = "Содержимое коментария")]
        public string Content { get; set; }
    }
}