(function () {
    'use strict';

    function CreateGameController($location, $cookies, ticTacToeGame) {
        var vm = this;

        vm.createGame = function () {
            ticTacToeGame.createGame()
                .then(function (response) {
                    alert('GAME CREATED!');                    
                    $cookies.put('MyGame', response.data);
                    $location.path('/game/' + response.data);
                });
        }
    }

    angular.module('ticTacToeApp.controllers')
        .controller('CreateGameController', ['$location', '$cookies', 'ticTacToeGame', CreateGameController]);
}())