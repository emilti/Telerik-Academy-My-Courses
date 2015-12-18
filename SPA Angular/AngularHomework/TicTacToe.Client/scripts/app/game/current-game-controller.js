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
            vm.box11 = gameStatus.data.Board[0];
            vm.box12 = gameStatus.data.Board[1];
            vm.box13 = gameStatus.data.Board[2];

            vm.box21 = gameStatus.data.Board[3];
            vm.box22 = gameStatus.data.Board[4];
            vm.box23 = gameStatus.data.Board[5];

            vm.box31 = gameStatus.data.Board[6];
            vm.box32 = gameStatus.data.Board[7];
            vm.box33 = gameStatus.data.Board[8];
            identity.getUser()
                .then(function (user) {
                    vm.user = user;
                    // console.log('inside ' + gameStatus.data)
                    if (gameStatus.data.State == "0") {
                        vm.waitForJoin = true;
                        vm.makeTurn = false;
                        vm.waitForOppponentMove = false;
                    }
                    else if ((gameStatus.data.State == "1" && gameStatus.data.FirstPlayerName == vm.user.Email) ||
                        (gameStatus.data.State == "2" && gameStatus.data.SecondPlayerName == vm.user.Email)) {
                        vm.makeTurn = true;
                        vm.waitForOppponentMove = false;
                        vm.waitForJoin = false;
                    }
                    else if ((gameStatus.data.State == "1" && gameStatus.data.SecondPlayerName == vm.user.Email) ||
                        (gameStatus.data.State == "2" && gameStatus.data.FirstPlayerName == vm.user.Email)) {
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