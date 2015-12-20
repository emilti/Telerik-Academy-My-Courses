(function () {
    'use strict';

    function CurrentGameController($location, $timeout, $scope, ticTacToeGame, identity) {
        var vm = this;

        // var result = getStatus();

        function refresh() {
            ticTacToeGame.getStatus()
            .then(function (response) {
                Check(response);
            })

            $timeout(refresh, 3000);
        };

        $timeout(refresh, 3000);

        vm.play = function (row, col) {
            var move = { row : row, col: col }
            console.log(move);
            ticTacToeGame.playMove(move)
                .then(function (response) {
                    $timeout(refresh, 3000);
                });
        }



        function Check(gameStatus) {
            console.log(gameStatus);   
            vm.box11 = gameStatus.Board[0];
            vm.box12 = gameStatus.Board[1];
            vm.box13 = gameStatus.Board[2];

            vm.box21 = gameStatus.Board[3];
            vm.box22 = gameStatus.Board[4];
            vm.box23 = gameStatus.Board[5];

            vm.box31 = gameStatus.Board[6];
            vm.box32 = gameStatus.Board[7];
            vm.box33 = gameStatus.Board[8];
            identity.getUser()
                .then(function (user) {
                    vm.user = user;
                    // console.log('inside ' + gameStatus.data)
                    if (gameStatus.State == "0") {
                        vm.waitForJoin = true;
                        vm.makeTurn = false;
                        vm.waitForOppponentMove = false;
                    }
                    else if ((gameStatus.State == "1" && gameStatus.FirstPlayerName == vm.user.Email) ||
                        (gameStatus.State == "2" && gameStatus.SecondPlayerName == vm.user.Email)) {
                        vm.makeTurn = true;
                        vm.waitForOppponentMove = false;
                        vm.waitForJoin = false;
                    }
                    else if ((gameStatus.State == "1" && gameStatus.SecondPlayerName == vm.user.Email) ||
                        (gameStatus.State == "2" && gameStatus.FirstPlayerName == vm.user.Email)) {
                        vm.makeTurn = false;
                        vm.waitForOppponentMove = true;
                        vm.waitForJoin = false;
                    }
                });
        }
    }

    angular.module('ticTacToeApp.controllers')
        .controller('CurrentGameController', ['$location', '$timeout', '$scope', 'ticTacToeGame', 'identity', CurrentGameController]);
}())