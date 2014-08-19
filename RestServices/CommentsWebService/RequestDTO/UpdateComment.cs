using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreServices.IModels;
using ServiceStack;

namespace RestServices.CommentsWebService.RequestDTO
{
    [Api(Description = "Обновление комментария вопроса")]
    [Route("/сomments/update", WebMethods.Update)]
    public class UpdateComment : IReturn
    {
        [ApiMember(Description = "Идентификатор коментария")]
        public int Id { get; set; }

        [ApiMember(Description = "Идентификатор вопроса")]
        public int QuestionId { get; set; }

        [ApiMember(Description = "Содержимое кометнтария вопроса")]
        public string Content { get; set; }
    }
}