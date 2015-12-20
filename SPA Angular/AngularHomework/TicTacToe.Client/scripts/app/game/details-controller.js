(function(){
    'use strict';
    function DetailsController($location, $cookies, ticTacToeGame) {
        var vm = this;
        ticTacToeGame.details()
           .then(function (response) {
               console.log(response)
               vm.Id = response.Id;
               vm.FirstPlayer = response.FirstPlayerName;
               vm.SecondPlayer = response.SecondPlayerName;
           })


            vm.join = function () {
        ticTacToeGame.joinGame(vm.Id)
            .then(function (response) {
                alert('GAME JOINED!');
                console.log(response);
                $cookies.put('MyGame', response);
                $location.path('/game/' + response);
            });
    }
    }

   

    angular.module('ticTacToeApp.controllers')
     .controller('DetailsController', ['$location', '$cookies', 'ticTacToeGame', DetailsController]);
}())