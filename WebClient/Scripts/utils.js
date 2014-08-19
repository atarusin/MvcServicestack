'use strict';

// Модуль фильтров
var extUtils = angular.module('extUtils', []);

extUtils.config(['$routeProvider', '$injector', function ($routeProvider, $injector) {

    if (bootbox) {
        // конфигурация бутбокса
        //bootbox.addLocale('rus', { OK: "OK", CANCEL: "Отмена", CONFIRM: "Подтвердить" });
        //bootbox.setBtnClasses({
        //    OK: "btn btn-primary",
        //    CONFIRM: "btn btn-primary",
        //    CANCEL: "btn btn-default"
        //});
        bootbox.setDefaults({
            locale: 'ru'
        });
    }
}]);

extUtils.factory('restNotify', [
        '$q', '$templateCache', '$compile', '$http', '$rootScope', function ($q, $cache, $compile, $http, $rootScope) {

            var notifyBase = function (message, fn) { //базовая функция для показа окон
                var deferred = $q.defer();

                fn(message, function (result) {
                    if (result || typeof (result) == "undefined") {
                        deferred.resolve();
                    } else {
                        deferred.reject();
                    }
                });
                return deferred.promise;
            };
            return {
                alert: function (message) { return notifyBase(message, bootbox.alert); },
            };
        }
])