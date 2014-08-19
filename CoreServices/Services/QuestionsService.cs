using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreServices.IModels;
using CoreServices.IServices;

namespace CoreServices.Services
{
    public class QuestionsService : IQuestionsService
    {

        public IEnumerable<IQuestion> Get(IQuestionFilter usersFilters)
        {
            throw new NotImplementedException();
        }

        public IQuestion Get(int id)
        {
            throw new NotImplementedException();
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
