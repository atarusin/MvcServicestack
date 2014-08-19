'use strict';

// Модуль сервисов
var restApi = angular.module('restApi', []);

restApi.service('restWebApi', ['$http', '$q', function ($http, $q) {

    var urlBase, createConfig, me;

    me = this;
    urlBase = '/rest';

    createConfig = function (method, url, data, skipErrorProcessing, options) {
        return angular.extend({
            method: method,
            url: urlBase + url,
            data: (data === undefined) ? null : data,
            params: (method === "GET") ? data : null,
            timeout: 30000,
            cache: false,
            skipErrorProcessing: angular.isDefined(skipErrorProcessing) ? skipErrorProcessing : false,
            skipErrorCodes: angular.isArray(skipErrorProcessing) ? skipErrorProcessing : []
        }, options);
    };
    


    me.getQuestions = function (filter) {
        return $http(createConfig('GET', '/questions/', filter, true));
    };
    
    me.getQuestion = function (questionId) {
        return $http(createConfig('GET', '/questions/' + questionId));
    };
    
    me.createQuestion = function (question) {
        return $http(createConfig('POST', '/questions/create', question, true));
    };

    me.updateQuestion = function (question) {
        return $http(createConfig('PUT', '/questions/update', question, true));
    };

    me.deleteQuestion = function (questionId) {
        return $http(createConfig('DELETE', '/questions/' + questionId + '/delete'));
    };
    


    me.getComments = function (filter) {
        return $http(createConfig('GET', '/comments/', filter, true));
    };

    me.getComment = function (commentId) {
        return $http(createConfig('GET', '/comments/' + commentId));
    };

    me.createComment = function (comment) {
        return $http(createConfig('POST', '/comments/create', comment, true));
    };

    me.updateComment = function (comment) {
        return $http(createConfig('PUT', '/comments/update', comment, true));
    };

    me.deleteComment = function (commentId) {
        return $http(createConfig('DELETE', '/comments/' + commentId + '/delete'));
    };



    me.getCategories = function (filter) {
        return $http(createConfig('GET', '/categories/', filter, true));
    };

    me.getCategory = function (categoryId) {
        return $http(createConfig('GET', '/categories/' + categoryId));
    };

    me.createCategory = function (category) {
        return $http(createConfig('POST', '/categories/create', category, true));
    };

    me.updateCategory = function (category) {
        return $http(createConfig('PUT', '/categories/update', category, true));
    };
    


    me.getQuestionStatuses = function (filter) {
        return $http(createConfig('GET', '/statuses/', filter, true));
    };

    me.getStatus = function (statusId) {
        return $http(createConfig('GET', '/statuses/' + statusId));
    };
    
}]);

