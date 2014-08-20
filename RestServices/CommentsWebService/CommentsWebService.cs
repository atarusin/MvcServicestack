using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CoreServices.IModels;
using CoreServices.IServices;
using RestServices.CommentsWebService.RequestDTO;
using ServiceStack.ServiceInterface;

namespace RestServices.CommentsWebService
{
    public class CommentsWebService : Service
    {
        readonly ICommentsService _service;

        public CommentsWebService(ICommentsService coreService)
        {
            _service = coreService;
        }

        public IComment Get(GetCommentById value)
        {
            return _service.Get(value.Id);
        }

        public IEnumerable<IComment> Get(GetCommentsByFilter filter)
        {
            return _service.Get(filter);
        }

        public void Post(CreateComment value)
        {
            _service.Save(value.ConvertTo());
        }

        public void Put(UpdateComment value)
        {
            _service.Save(value.ConvertTo());
        }
    }
}