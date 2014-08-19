using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreServices.IModels;
using CoreServices.IServices;

namespace CoreServices.Services
{
    public class CategoriesService : ICategoriesService
    {

        public IEnumerable<ICategory> Get(ICategoryFilter usersFilters)
        {
            throw new NotImplementedException();
        }

        public ICategory Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(ICategory value)
        {
            throw new NotImplementedException();
        }
    }
}
