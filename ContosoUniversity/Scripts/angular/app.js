var Grunden = {};
Grunden.treeApp = angular.module("treeApp", ['ngRoute'])
.controller("studentCtrl", function ($scope, dataService, $routeParams) {
    $scope.model = {};
    $scope.namn = "";
    $scope.model.student = {};
    $scope.model.enrollments = [];
    $scope.$watch("model.student", function () { console.log('Kontroller säger: ändring') });
    dataService.getStudent($routeParams.id)
    .then(
        function (student) {
            //success
            angular.copy(student.data, $scope.model.student);
            $scope.namn = $scope.model.student.lastName;
        },
        function () {
            //error
            alert("Det gick inte att hämta studenten");
        }
    );
    dataService.getEnrollments($routeParams.id)
    .then(
        function (enrollments) {
            //success
            angular.copy(enrollments, $scope.model.enrollments);
        },
        function () {
            //error
            alert("Det gick inte att hämta studenten");
        }
    );
})
.config(function($routeProvider) {
    $routeProvider.when("/student/:id", {
        controller: "studentCtrl",
        templateUrl: "/templates/student.html"
    });
})

.factory("dataService", function($http, $q) {
    var _enrollments = [];
    var _student = null;
    var _getEnrollments = function (id) {
        var deferred = $q.defer();
        $http({
            url: "/Tree/LoadEnrollments/",
            method: "GET",
            params: { id: id }
        })
        .then(function (result) {
            //success
            angular.copy(result.data, _enrollments);
            deferred.resolve(_enrollments);
        },
        function () {
            //error
            deferred.reject();
        });

        return deferred.promise;
    };
    var _getStudent = function (id) {
        var deferred = $q.defer();
        $http({
            url: "/Tree/LoadStudent/",
            method: "GET",
            params: {id:id}
        })
        .then(function (result) {
            //success
            _student = result;
            deferred.resolve(result);
        },
        function () {
            //error
            deferred.reject();
        });

        return deferred.promise;
    };

    return {
        //API av funktioner och eller properties
        //Kan med fördel använda closure.
        student: _student,
        getEnrollments: _getEnrollments,
        getStudent: _getStudent,
    };
});

