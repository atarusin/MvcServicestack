using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreServices.IModels
{
    public interface IQuestion
    {
        int Id { get; set; }
        int CategoryId { get; set; }
        int StatusId { get; set; }
        string Title { get; set; }
        string Content { get; set; }

        ICategory Category { get; set; }
        IEnumerable<IComment> Comments { get; set; }
        IQuestionStatus QuestionStatus { get; set; }
    }
}
