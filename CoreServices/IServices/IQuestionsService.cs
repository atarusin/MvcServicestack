using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreServices.IModels;

namespace CoreServices.IServices
{
    public interface IQuestionsService : ICoreServiceRead<IQuestion, IQuestionFilter, int>, ICoreServiceWrite<IQuestion>, ICoreServiceDelete<int>
    {
        
    }
}
