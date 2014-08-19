using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreServices.IModels;

namespace CoreServices.IServices
{
    public interface ICommentsService : ICoreServiceRead<IComment, ICommentFilter, int>, ICoreServiceWrite<IComment>, ICoreServiceDelete<int>
    {
        
    }
}
