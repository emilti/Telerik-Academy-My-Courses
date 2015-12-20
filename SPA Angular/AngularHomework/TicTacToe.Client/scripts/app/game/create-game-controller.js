(function () {
    'use strict';

    function CreateGameController($location, $cookies, ticTacToeGame) {
        var vm = this;

        vm.createGame = function () {
            ticTacToeGame.createGame()
                .then(function (response) {
                    alert('GAME CREATED!');
                    console.log(response)
                    $cookies.put('MyGame', response);
                    $location.path('/game/' + response);
                });
        }
    }

    angular.module('ticTacToeApp.controllers')
        .controller('CreateGameController', ['$location', '$cookies', 'ticTacToeGame', CreateGameController]);
}())