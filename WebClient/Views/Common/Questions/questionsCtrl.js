// Контроллер всей страницы
angularApp.controller('questionsCtrl', ['$scope', '$location', '$window', 'restWebApi',
    function ($scope, $location, $window, api
    ) {
        var data = {
            isLoad: function () { return data.list && data.list.items; },
            list: { items: null, filters: {} }
        };
        $scope.data = data;

        //$scope.edit = function (id) {
        //};

        function loadList() {
            
            api.getQuestions(data.list.filters).success(function (result) {
                data.list.items = result;
            });

        }

        (function load() {
            loadList();
        })();
    }]);
