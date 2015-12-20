(function () {
    'use strict';

    function JoinGameController($location, $cookies, ticTacToeGame) {
        var vm = this;

        vm.join = function () {
            ticTacToeGame.joinGame()
                .then(function (response) {
                    alert('GAME JOINED!');
                    console.log(response);
                    $cookies.put('MyGame', response);
                    $location.path('/game/' + response);
                });
        }
    }

    angular.module('ticTacToeApp.controllers')
        .controller('JoinGameController', ['$location', '$cookies', 'ticTacToeGame', JoinGameController]);
}())