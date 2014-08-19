using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CoreServices.IModels;
using DataStorage;

namespace CoreServices.Mappers
{
    public static class QuestionsModelMappers
    {
        static QuestionsModelMappers()
        {
            CreateMap();
        }

        private static bool _isCreateMap;

        public static void CreateMap()
        {
            if (_isCreateMap)
                return;
            _isCreateMap = true;

            Mapper.CreateMap<Category, ICategory>()
                  .ForMember(obj => obj.Questions, opt => opt.Ignore())
                  .AfterMap((from, to) =>
                      {
                          try
                          {
                              if (from.Questions.Any())
                                  to.Questions = from.Questions.Select(Mapper.Map<Question, IQuestion>).ToList();
                          }
                          catch (Exception) { }
                      });
            Mapper.CreateMap<ICategory, Category>()
                  .ForMember(obj => obj.Questions, opt => opt.Ignore());
                //.AfterMap((from, to) =>
                //    {
                //        try
                //        {
                //            if (from.Questions.Any())
                //                to.Questions = from.Questions.Select(Mapper.Map<IQuestion, Question>).ToList();
                //        }
                //        catch (Exception) { }
                //    });

            Mapper.CreateMap<Comment, IComment>()
                  .ForMember(obj => obj.Question, opt => opt.Ignore())
                  .AfterMap((from, to) =>
                  {
                      try { if (from.Question != null) to.Question = from.Question.ConvertTo(); }
                      catch (Exception) { }
                  });
            Mapper.CreateMap<IComment, Comment>()
                  .ForMember(obj => obj.Question, opt => opt.Ignore());

            Mapper.CreateMap<QuestionStatus, IQuestionStatus>()
                  .ForMember(obj => obj.Questions, opt => opt.Ignore())
                  .AfterMap((from, to) =>
                      {
                          try
                          {
                              if (from.Questions.Any())
                                  to.Questions = from.Questions.Select(Mapper.Map<Question, IQuestion>).ToList();
                          }
                          catch (Exception) { }
                      });
            Mapper.CreateMap<IQuestionStatus, QuestionStatus>()
                  .ForMember(obj => obj.Questions, opt => opt.Ignore());

            Mapper.CreateMap<Question, IQuestion>()
                  .ForMember(obj => obj.Category, opt => opt.Ignore())
                  .ForMember(obj => obj.QuestionStatus, opt => opt.Ignore())
                  .ForMember(obj => obj.Comments, opt => opt.Ignore())
                  .AfterMap((from, to) =>
                  {
                      try { if (from.Category != null) to.Category = from.Category.ConvertTo(); }
                      catch (Exception) { }
                      try { if (from.QuestionStatus != null) to.QuestionStatus = from.QuestionStatus.ConvertTo(); }
                      catch (Exception) { }
                      try { if (from.Comments.Any()) to.Comments = from.Comments.Select(Mapper.Map<Comment, IComment>).ToList(); }
                      catch (Exception) { }
                  });
            Mapper.CreateMap<IQuestion, Question>()
                  .ForMember(obj => obj.Category, opt => opt.Ignore())
                  .ForMember(obj => obj.QuestionStatus, opt => opt.Ignore())
                  .ForMember(obj => obj.Comments, opt => opt.Ignore());
        }

        public static ICategory ConvertTo(this Category value)
        {
            return Mapper.Map<Category, ICategory>(value);
        }

        public static IComment ConvertTo(this Comment value)
        {
            return Mapper.Map<Comment, IComment>(value);
        }

        public static IQuestion ConvertTo(this Question value)
        {
            return Mapper.Map<Question, IQuestion>(value);
        }

        public static IQuestionStatus ConvertTo(this QuestionStatus value)
        {
            return Mapper.Map<QuestionStatus, IQuestionStatus>(value);
        }

    }
}
