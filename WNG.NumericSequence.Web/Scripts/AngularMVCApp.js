var AngularMVCApp = angular.module('AngularMVCApp', ['ngMessages']);

AngularMVCApp.controller('SequencesController', ['$scope', '$http', function ($scope, $http) {
    $scope.model = {
        Title: 'I work!'
    };
    $scope.geojson = {};

    $scope.sendForm = function () {
        $http({
            method: 'POST',
            url: '/Sequences/Process',
            data: $scope.model
        }).success(function (data, status, headers, config)
        {
            SetResult(data);
  
        }).error(function (data, status, headers, config)
        {

        });
    };

    function SetResult(data)
    {

        $scope.geojson =
                {
                    asc: data[0].Values,
                    evenASC: data[1].Values,
                    oddASC: data[3].Values,
                    fibonacci: data[2].Values,
                    substitution: data[4].Values
                };
    }




}]);

//var configFunction = function ($routeProvider) {
//    $routeProvider.
//        when('/routeOne', {
//            templateUrl: 'routesDemo/one'
//        })
//        .when('/routeTwo/:donuts', {
//            templateUrl: function (params) { return '/routesDemo/two?donuts=' + params.donuts; }
//        })
//        .when('/routeThree', {
//            templateUrl: 'routesDemo/three'
//        })
//          .when('/process', {
//              templateUrl: 'routesDemo/Process',
//              controller: SequenceController,
//              paramExample: 'exampleB'
//          });
//}
//configFunction.$inject = ['$routeProvider'];

//AngularMVCApp.config(configFunction);