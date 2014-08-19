// Контроллер всей страницы
angularApp.controller('mainPageCtrl', ['$rootScope', '$scope', '$location', '$window',
    function ($rootScope, $scope, $location, $window) {

        $scope.isPathContain = function (path) {
            if ($location.path().substr(0, path.length) === path) {
                return true;
            }
            return false;
        };

    }]);
