﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreServices.IModels;
using ServiceStack;

namespace RestServices.CategoriesWebService.RequestDTO
{
    [Api(Description = "Получение катигории вопросов")]
    [Route("/categories/update", WebMethods.Update)]
    public class UpdateCategory : IReturn
    {
        [ApiMember(Description = "Идентификатор катигории вопросов")]
        public int Id { get; set; }

        [ApiMember(Description = "Название катигории вопросов")]
        public string Title { get; set; }
    }
}