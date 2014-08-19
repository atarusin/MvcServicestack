'use strict';

// Модуль приложения оператора
var angularApp = angular.module('mainPageApp', [
	'ngRoute',
    'restApi'
]);

////Переносим r-token и expiresIn из кук в localStorage
//angularApp.run(['WebOfficeApi', function (api) {     api.startSession(); }]);

// Настройки модуля
angularApp.config(['$routeProvider', '$injector', function ($routeProvider, $injector) {

    $routeProvider
        .when('/list', { templateUrl: 'Home/PartsViews/List/viewList', controller: 'viewListCtrl' })
        //.when('/list/:id', { templateUrl: '/Home/List/viewEdit', controller: 'editListCtrl' })
        .otherwise({ redirectTo: '/list' });
}]);