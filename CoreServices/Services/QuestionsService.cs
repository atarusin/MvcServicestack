using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreServices.IModels;
using CoreServices.IServices;
using CoreServices.Mappers;
using DataStorage;

namespace CoreServices.Services
{
    public class QuestionsService : IQuestionsService
    {

        public IEnumerable<IQuestion> Get(IQuestionFilter filter)
        {
            IEnumerable<Question> list;
            var ent = new QuestionsEntities();
            try
            {
                var dbq = ent.Questions.Include("QuestionStatuses").Include("Categories");
                var q = dbq.Select(s => s);

                if (filter != null)
                {
                    if (filter.Id > 0)
                        q = q.Where(s => s.Id == filter.Id);
                    else
                    {
                        if (filter.StatusId > 0)
                            q = q.Where(s => s.StatusId == filter.StatusId);
                        if (filter.CategoryId > 0)
                            q = q.Where(s => s.CategoryId == filter.CategoryId);
                        if (!String.IsNullOrWhiteSpace(filter.Title))
                            q = q.Where(s => s.Title.Contains(filter.Title));
                        if (!String.IsNullOrWhiteSpace(filter.Content))
                            q = q.Where(s => s.Content.Contains(filter.Content));
                        //if (filter.FromDate != null)
                        //    q = q.Where(s => s.Date >= filter.FromDate);
                        //if (filter.ToDate != null)
                        //    q = q.Where(s => s.Date < filter.ToDate);
                    }
                }
                list = q.ToList();
            }
            catch (Exception)
            {
                list = new List<Question>();
            }
            finally
            {
                ent.Dispose();
            }
            return list.Select(s => s.ConvertTo()).ToList();
        }

        public IQuestion Get(int id)
        {
            IQuestion question = null;
            using (var ent = new QuestionsEntities())
                if (id > 0)
                {
                    var dbq = ent.Questions.Include("QuestionStatuses").Include("Categories");
                    var q = dbq.Where(s => s.Id == id).Select(s => s);

                    if (q.Any())
                        question = q.First().ConvertTo();
                }
            return question;
        }

        public void Save(IQuestion value)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
