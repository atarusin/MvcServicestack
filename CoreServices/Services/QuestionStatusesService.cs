using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreServices.IModels;

namespace CoreServices.IServices
{
    public class QuestionStatusesService : IQuestionStatusesService
    {

        public IEnumerable<IQuestionStatus> Get(IQuestionStatusFilter usersFilters)
        {
            throw new NotImplementedException();
        }

        public IQuestionStatus Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
