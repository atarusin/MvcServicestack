using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CoreServices.IModels;
using CoreServices.IServices;
using RestServices.CategoriesWebService.RequestDTO;
using ServiceStack.ServiceInterface;

namespace RestServices.CategoriesWebService
{
    public class CategoriesWebService : Service
    {
        readonly ICategoriesService _service;

        public CategoriesWebService(ICategoriesService usersCoreService)
        {
            _service = usersCoreService;
        }

        public ICategory Get(GetCategoryById value)
        {
            return _service.Get(value.Id);
        }

        public IEnumerable<ICategory> Get(GetCategoriesByFilter filter)
        {
            return _service.Get(filter);
        }

        public void Post(CreateCategory value)
        {
            _service.Save(value.ConvertTo());
        }

        public void Put(UpdateCategory value)
        {
            _service.Save(value.ConvertTo());
        }
    }
}