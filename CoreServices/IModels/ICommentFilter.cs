using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreServices.IModels
{
    public interface ICommentFilter
    {
        int Id { get; set; }
        int QuestionId { get; set; }
        string Content { get; set; }
        //IQuestion Question { get; set; }
    }
}
