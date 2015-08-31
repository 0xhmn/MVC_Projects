// used in _Program.cshtml

angular.module("onlineApp").controller("AppSelectCtrl", [
    "$scope", function ($scope) {

        $scope.test = "test from controller";

        $scope.selections = {
            termName: "sfs"
        };
    }
]);