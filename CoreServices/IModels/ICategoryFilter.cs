using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreServices.IModels
{
    public interface ICategoryFilter
    {
        int Id { get; set; }
        string Title { get; set; }
        //IEnumerable<IQuestion> Questions { get; set; }
    }
}
