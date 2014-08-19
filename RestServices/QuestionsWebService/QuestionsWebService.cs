using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CoreServices.IModels;
using CoreServices.IServices;
using RestServices.QuestionsWebService.RequestDTO;
using ServiceStack;

namespace RestServices.QuestionsWebService
{
    public class QuestionsWebService : Service
    {
        readonly IQuestionsService _service;

        public QuestionsWebService(IQuestionsService coreService)
        {
            _service = coreService;
        }

        public IQuestion Get(GetQuestionById value)
        {
            return _service.Get(value.Id);
        }

        public IEnumerable<IQuestion> Get(GetQuestionsByFilter filter)
        {
            return _service.Get(filter);
        }

        public void Post(CreateQuestion value)
        {
            _service.Save(value.ConvertTo());
        }

        public void Put(UpdateQuestion value)
        {
            _service.Save(value.ConvertTo());
        }
    }
}