using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CoreServices.IModels;
using CoreServices.IServices;
using RestServices.QuestionStatusesWebService.RequestDTO;
using ServiceStack.ServiceInterface;

namespace RestServices.QuestionStatusesWebService
{
    public class QuestionStatusesWebService : Service
    {
        readonly IQuestionStatusesService _service;

        public QuestionStatusesWebService(IQuestionStatusesService coreService)
        {
            _service = coreService;
        }

        public IQuestionStatus Get(GetQuestionStatusById value)
        {
            return _service.Get(value.Id);
        }

        public IEnumerable<IQuestionStatus> Get(GetQuestionStatusesByFilter filter)
        {
            return _service.Get(filter);
        }
    }
}