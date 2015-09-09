(function(){
    var sammmyApp = Sammy('#content', function(){
        this.get('#/',function(){
            this.redirect('#/home');
        });

        this.get('#/home', homeController.all);
        this.get('#/register', usersController.register);
        this.get('#/login', usersController.login);
        // this.get('#/todos', todosController.all);
        // this.get('#/todos/add', todosController.add);
        // this.get('#/events', eventsController.all);
        // this.get('#/events/add', eventsController.add);
    });



    $(function(){
        sammmyApp.run('#/');

    //    $.ajax('api/categories',{
    //        contentType: 'application/json',
    //        headers: {
    //            'x-auth-key': localStorage.getItem('SPECIAL_AUTHENTICATION_KEY')
    //        },
    //        success: function(categories){
    //            toastr.info(JSON.stringify(categories));
    //            // resolve(categories);
    //        }
    //
    //    });
    });
}());
