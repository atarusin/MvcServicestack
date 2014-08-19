using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreServices.IModels;
using ServiceStack;

namespace RestServices.CommentsWebService.RequestDTO
{
    [Api(Description = "Получение списка коментариев вопроса")]
    [Route("/сomments", WebMethods.Get)]
    public class GetCommentsByFilter : ICommentFilter, IReturn<IEnumerable<IComment>>
    {
        [ApiMember(Description = "Идентификатор коментратия")]
        public int Id { get; set; }

        [ApiMember(Description = "Идентификатор вопроса")]
        public int QuestionId { get; set; }

        [ApiMember(Description = "Содержимое коментария")]
        public string Content { get; set; }
    }
}