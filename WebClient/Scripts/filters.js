'use strict';

// Модуль фильтров
var extFilters = angular.module('extFilters', []);

//extFilters.filter('getCreateOrEdit', function () {
//    return function (isCreate, format) {
//        if (angular.isUndefined(isCreate))
//            return "";
//        return isCreate ? "Создать" : "Редактировать";
//    };
//});

//extFilters.filter('getMaleOrFemale', function () {
//    return function (isMale, format) {
//        if (angular.isUndefined(isMale))
//            return "";
//        return isMale ? "муж." : "жен.";
//    };
//});

//extFilters.filter('moment', function () {
//    return function (dateObj, format) {
//        if (angular.isUndefined(dateObj))
//            return "";

//        var m = moment(dateObj);

//        if (!m.isValid())
//            throw "Попытка форматирования некорректной даты";

//        var result = m.format(format);

//        return result;

//    };
//});

