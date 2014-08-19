using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CoreServices.IModels;
using RestServices.CategoriesWebService.RequestDTO;
using RestServices.CommentsWebService.RequestDTO;
using RestServices.QuestionsWebService.RequestDTO;

namespace RestServices
{
    public static class DTOMappers
    {
        static DTOMappers()
        {
            CreateMap();
        }

        private static bool _isCreateMap;

        public static void CreateMap()
        {
            if (_isCreateMap)
                return;
            _isCreateMap = true;

            Mapper.CreateMap<CreateCategory, ICategory>();
            Mapper.CreateMap<UpdateCategory, ICategory>();

            Mapper.CreateMap<CreateComment, IComment>();
            Mapper.CreateMap<UpdateComment, IComment>();

            Mapper.CreateMap<CreateQuestion, IQuestion>();
            Mapper.CreateMap<UpdateQuestion, IQuestion>();
        }

        public static ICategory ConvertTo(this CreateCategory value)
        {
            return Mapper.Map<CreateCategory, ICategory>(value);
        }

        public static ICategory ConvertTo(this UpdateCategory value)
        {
            return Mapper.Map<UpdateCategory, ICategory>(value);
        }

        public static IComment ConvertTo(this CreateComment value)
        {
            return Mapper.Map<CreateComment, IComment>(value);
        }

        public static IComment ConvertTo(this UpdateComment value)
        {
            return Mapper.Map<UpdateComment, IComment>(value);
        }

        public static IQuestion ConvertTo(this CreateQuestion value)
        {
            return Mapper.Map<CreateQuestion, IQuestion>(value);
        }

        public static IQuestion ConvertTo(this UpdateQuestion value)
        {
            return Mapper.Map<UpdateQuestion, IQuestion>(value);
        }

    }
}