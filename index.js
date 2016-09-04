





var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope, $http) {
    $http.get("http://localhost:56469/api/TopSpots").then(function (response) {
        $scope.spots = response.data;

        
    });
});


