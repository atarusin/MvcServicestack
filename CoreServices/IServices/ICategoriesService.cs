using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreServices.IModels;

namespace CoreServices.IServices
{
    public interface ICategoriesService : ICoreServiceRead<ICategory, ICategoryFilter, int>, ICoreServiceWrite<ICategory>
    {
        
    }
}
