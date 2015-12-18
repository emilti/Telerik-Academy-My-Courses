(function () {
    'use strict';

    function config($routeProvider, $locationProvider) {
        var CONTROLLER_VIEW_MODEL_NAME = 'vm';
        $locationProvider.html5Mode(true);

        var routeResolvers = {
            authenticationRequired: {
                authenticate: ['$q', 'auth', function ($q, auth) {
                    if (auth.isAuthenticated()) {
                        return true;
                    }

                    return $q.reject('not authorized');
                }]
            }
        }

        $routeProvider
            .when('/', {
                templateUrl: 'partials/home/home.html',
                controller: 'HomeController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/identity/register', {
                templateUrl: 'partials/identity/register.html',
                controller: 'RegisterController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
             .when('/identity/login', {
                 templateUrl: 'partials/identity/login.html',
                 controller: 'LoginController',
                 controllerAs: CONTROLLER_VIEW_MODEL_NAME
             })
            .when('/game/creategame', {
                templateUrl: 'partials/game/create-game.html',
                controller: 'CreateGameController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/game/joingame', {
                templateUrl: 'partials/game/join-game.html',
                controller: 'JoinGameController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/game/:gameid', {
                templateUrl: 'partials/game/current-game.html',
                controller: 'CurrentGameController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .otherwise({ redirectTo: '/' })
    }

    function run($http, cookies, $rootScope, $location, auth) {
        $rootScope.$on('$routeChangeError', function (ev, current, previous, rejection) {
            if (rejection === 'not authorized') {
                $location.path('/');
            }
        });

        if (auth.isAuthenticated()) {
            $http.defaults.headers.common.Authorization = 'Bearer ' + cookies.get('authentication');
            auth.getIdentity()
        }
    };

    angular.module('ticTacToeApp.services', []);
    angular.module('ticTacToeApp.controllers', ['ticTacToeApp.services']);


    angular.module('ticTacToeApp', ['ngRoute', 'ngCookies', 'ticTacToeApp.controllers'])
        .config(['$routeProvider', '$locationProvider', config])
        .run(['$http', '$cookies', '$rootScope', '$location', 'auth', run])
        .constant('baseUrl', 'http://localhost:33257/');
}())