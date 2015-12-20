(function () {
    'use strict';

    function listedGamesDirective() {
        return {
            restrict: 'A',
            templateUrl: 'partials/home/listed-games-directive.html'
        }
    }

    angular.module('ticTacToeApp.directives')
        .directive('listedGamesDirective', [listedGamesDirective])
}());