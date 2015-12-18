(function () {
    'use strict';

    function RegisterController($location, auth) {
        var vm = this;

        vm.register = function(user, registerForm){
            if (registerForm.$valid) {
                console.log('...TRYING TO REGISTER USER...')
                auth.register(user)
                .then(function () {
                    console.log("....USER REGISTERED...")
                    $location.path('/identity/login')
                })
            }
        }
    }

    angular.module('ticTacToeApp.controllers')
        .controller('RegisterController', ['$location', 'auth', RegisterController]);

}())