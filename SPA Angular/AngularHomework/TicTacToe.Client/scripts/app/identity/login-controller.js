(function () {
    'use strict';
    function LoginController($location, auth) {
        var vm = this;

        vm.login = function (user, loginForm) {
            if (loginForm.$valid) {
                console.log('...TRY TO LOGIN USER...');
                auth.login(user)
                    .then(function () {
                        console.log('...LOGIN WORKS...');
                        $location.path('/');
                    });
            }
        }
    }

    angular.module('ticTacToeApp.controllers')
        .controller('LoginController', ['$location', 'auth', LoginController]);
}())