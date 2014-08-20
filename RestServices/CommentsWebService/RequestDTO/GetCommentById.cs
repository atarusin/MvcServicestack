using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreServices.IModels;
using ServiceStack;
using ServiceStack.ServiceHost;

namespace RestServices.CommentsWebService.RequestDTO
{
    [Api(Description = "Получение коментария вопроса")]
    [Route("/Comments/{Id}", WebMethods.Get)]
    public class GetCommentById : IReturn<IComment>
    {
        [ApiMember(Description = "Идентификатор коментария")]
        public int Id { get; set; }
    }
}