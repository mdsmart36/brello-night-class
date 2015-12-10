var app = angular.module('Brello', []);

app.controller("BoardController", ["$scope", function ($scope) {
    $scope.test = "Hello World!";

    $scope.hello = function () {
        $scope.test = "Hello, is it me you're looking for?";
    }
}]);