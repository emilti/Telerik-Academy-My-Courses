(function () {
    'use strict';
    function HomeController(identity, ticTacToeGame) {
        var vm = this;

        waitForLogin();
        
        ticTacToeGame.getGames()
           .then(function (games) {               
               vm.games = games;             
           });

        function waitForLogin() {
            identity.getUser()
            .then(function (user) {
                vm.userLogged = user;
            });
        }
    }

    angular.module('ticTacToeApp.controllers')
        .controller('HomeController', ['identity', 'ticTacToeGame', HomeController]);
}())