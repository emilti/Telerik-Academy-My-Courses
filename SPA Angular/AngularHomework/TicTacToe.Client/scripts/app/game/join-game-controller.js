(function () {
    'use strict';

    function JoinGameController($location, ticTacToeGame) {
        var vm = this;

        vm.join = function () {
            ticTacToeGame.joinGame()
                .then(function (response) {
                    alert('GAME JOINED!');                   
                    $location.path('/game/' + response.data);
                });
        }
    }

    angular.module('ticTacToeApp.controllers')
        .controller('JoinGameController', ['$location', 'ticTacToeGame', JoinGameController]);
}())