using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreServices.IModels;
using CoreServices.IServices;

namespace CoreServices.Services
{
    public class CommentsService : ICommentsService
    {

        public IEnumerable<IComment> Get(ICommentFilter usersFilters)
        {
            throw new NotImplementedException();
        }

        public IComment Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(ICommentFilter usersFilters)
        {
            throw new NotImplementedException();
        }

        public void Save(IComment value)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
