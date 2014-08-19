// Контроллер всей страницы
angularApp.controller('viewListCtrl', ['$scope', '$location', '$window', 'restWebApi',
    function ($scope, $location, $window, api
    ) {

        var data = {
            isLoad: function () { return data.users && data.users.items; },
            users: { items: null, filters: {} }
        };
        $scope.data = data;

        function loadUsers() {

            api.getUsers(data.users.filters).success(function (result) {
                data.users.items = result;
            });

        }

        (function load() {
            loadUsers();
        })();
    }]);
