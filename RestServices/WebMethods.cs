using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestServices
{
    /// <summary>
    /// Содержит константы с наименованиями web-методов для CRUD-операций. 
    /// </summary>
    internal static class WebMethods
    {
        /// <summary>
        /// Создание данных.
        /// </summary>
        public const string Create = "POST";

        /// <summary>
        /// Получение данных.
        /// </summary>
        public const string Read = "GET";

        /// <summary>
        /// Получение данных.
        /// </summary>
        public const string Get = Read;

        /// <summary>
        /// Изменение данных.
        /// </summary>
        public const string Update = "PUT";

        /// <summary>
        /// Удаление данных.
        /// </summary>
        public const string Delete = "DELETE";
    }
}