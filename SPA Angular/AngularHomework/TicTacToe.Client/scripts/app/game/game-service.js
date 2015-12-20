(function () {
    'use strict';

    function ticTacToeGameService($routeParams, $cookies, data) {

        function getGames() {
            return data.get('api/games/GetGames');
        }
        

        function createGame() {
            return data.post('api/games/create');           
        }

        function joinGame(id) {
            console.log(id)
            var gameForJoin = {gameId: id}
            return data.post('api/games/join', gameForJoin);
        }

        function getStatus() {            
            var gameId = { gameId: $routeParams.gameid };
            return data.get('api/games/status', gameId);           
        }

        function details() {
            var gameId = { gameId: $routeParams.gameid };
            return data.get('api/games/details', gameId);
        }

        function playMove(move) {   
            var gameId = $cookies.get('MyGame');
            var moveForServer = { gameId: gameId, row: move.row, col: move.col };
            console.log(moveForServer);
            return data.post('api/games/Play', moveForServer);
        }

        return {
            getGames: getGames,
            createGame: createGame,
            joinGame: joinGame,
            getStatus: getStatus,
            playMove: playMove,
            details: details
        }
    }

    angular.module('ticTacToeApp.services')
        .factory('ticTacToeGame', ['$routeParams', '$cookies','data', ticTacToeGameService]);
}())