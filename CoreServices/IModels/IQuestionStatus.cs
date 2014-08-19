using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreServices.IModels
{
    public interface IQuestionStatus
    {
        int Id { get; set; }
        string Name { get; set; }
        string LName { get; set; }

        IEnumerable<IQuestion> Questions { get; set; }
    }
}
