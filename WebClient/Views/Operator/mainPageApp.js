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

        .when('/questions', { templateUrl: '/Common/Questions/Questions', controller: 'questionsCtrl' })
        .when('/questions/:id', { templateUrl: '/Common/Questions/Question', controller: 'questionCtrl' })
        .when('/questions/create', { templateUrl: '/Common/Questions/QuestionEdit', controller: 'questionEditCtrl' })
        .when('/questions/:id/edit', { templateUrl: '/Common/Questions/QuestionEdit', controller: 'questionEditCtrl' })
        .otherwise({ redirectTo: '/questions' });
}]);