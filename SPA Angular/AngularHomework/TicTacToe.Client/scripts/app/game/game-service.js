(function () {
    'use strict';

    function ticTacToeGameService($http, $q, $cookies, baseUrl) {

        function createGame() {
            var defered = $q.defer();

            $http.post(baseUrl + 'api/games/create')
                .then(function (response) {
                    defered.resolve(response);
                }, function (err) {
                    defered.reject(err);
                });

            return defered.promise;
        }

        function joinGame() {
            var defered = $q.defer();

            $http.post(baseUrl + 'api/games/join')
                .then(function (response) {
                    defered.resolve(response);
                }, function (err) {
                    defered.reject(err);
                });

            return defered.promise;
        }

        function getStatus() {
            var defered = $q.defer();
            var gameId = $cookies.get('MyGame');
            $http.get(baseUrl + 'api/games/Status', {
                params: { gameId: gameId}
            })
                .then(function (response) {
                    defered.resolve(response);
                }, function (err) {
                    defered.reject(err);
                });

            return defered.promise;
        }

        function playMove(move) {
            var defered = $q.defer();
            console.log('move:' + move.row);
            
            var gameId = $cookies.get('MyGame');
            var moveForServer = { gameId: gameId, row: move.row, col: move.col };
            console.log('moveForServer:' + moveForServer);
            $http.post(baseUrl + 'api/games/play', moveForServer)
                 .then(function () {
                     defered.resolve(true);
                 }, function (err) {
                     defered.reject(err);
                 })

            return defered.promise;
        }

        return {
            createGame: createGame,
            joinGame: joinGame,
            getStatus: getStatus,
            playMove: playMove
        }
    }

    angular.module('ticTacToeApp.services')
        .factory('ticTacToeGame', ['$http', '$q', '$cookies', 'baseUrl', ticTacToeGameService]);
}())