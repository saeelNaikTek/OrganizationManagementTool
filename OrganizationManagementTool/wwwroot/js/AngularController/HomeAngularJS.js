
var app = angular.module("FacultyApp", []);

app.controller("FacultyController", function ($scope, $http){
    $scope.btnsave = "Save";
    $.savedata = function () {
        $scope.btnsave = "Please wait...";
        $http({
            method: 'POST',
            url: 'Faculty/AddFaculty',
            data: $scope.FacultyModel
        }).success(function (result) {
            $scope.btnsave = "Save";
            $scope.FacultyModel = null;
            alert(result);
        }).error(function () {
            alert('Failed');
        })
    }
});