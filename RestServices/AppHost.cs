﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using CoreServices.IServices;
using CoreServices.Services;
using CoreServices.Mappers;
using Funq;
using ServiceStack;
using ServiceStack.Common;
using ServiceStack.Common.Web;
//using ServiceStack.Logging;
using ServiceStack.ServiceHost;
//using ServiceStack.ServiceInterface.ServiceModel;
//using ServiceStack.Text;
using ServiceStack.WebHost.Endpoints;

namespace RestServices
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("MVC 4", typeof(AppHost).Assembly) { }

        public override void Configure(Container container)
        {
            bool isDebugMode = false;
#if(DEBUG)
            isDebugMode = true;
#endif

            SetConfig(new EndpointHostConfig
            {
                EnableFeatures = Feature.All.Remove(Feature.Jsv | Feature.Soap),
                //all formats except of JSV and SOAP
                DefaultContentType = ContentType.Json,
                AllowJsonpRequests = false,
                DebugMode = isDebugMode,
                MapExceptionToStatusCode =
                        {
                            {typeof (ObjectNotFoundException), 404},
                        }
            });

            QuestionsModelMappers.CreateMap();
            DTOMappers.CreateMap();

            container.Register<ICategoriesService>(o => new CategoriesService());
            container.Register<ICommentsService>(o => new CommentsService());
            container.Register<IQuestionStatusesService>(o => new QuestionStatusesService());
            container.Register<IQuestionsService>(o => new QuestionsService());
        }
    }
}