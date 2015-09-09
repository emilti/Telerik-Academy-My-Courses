(function(){
    var sammmyApp = Sammy('#content', function(){
        this.get('#/',function(){
            this.redirect('#/home');
        });

        this.get('#/home', homeController.all);
        this.get('#/register', usersController.register);
        this.get('#/login', usersController.login);
        this.get('#/posts', postsController.all);
        this.get('#/addPost', postsController.add);
        // this.get('#/todos/add', todosController.add);
        // this.get('#/events', eventsController.all);
        // this.get('#/events/add', eventsController.add);
    });



    $(function(){
        sammmyApp.run('#/');
        //console.log('1111')
        //console.log(usersController.current());
        //if (usersController.current()){
        //    $('#btn-go-to-login')
        //        .addClass('hidden');
        //    $('#btn-go-to-register')
        //        .addClass('hidden');
        //} else {
        //    $('#btn-logout')
        //        .addClass('hidden');
        //}
        //
        if (localStorage.getItem('STORAGE_USERNAME_KEY')){
            $('#btn-logout').addClass('hidden');
            $('#btn-go-to-login')
                .removeClass('hidden');
            $('#btn-go-to-register')
                .removeClass('hidden');
            location ='#/';
        }

        $('#btn-logout').on('click',function(){
                data.users.logout()
                .then(function(){
                        $('#btn-logout').addClass('hidden');
                        $('#btn-go-to-login')
                            .removeClass('hidden');
                        $('#btn-go-to-register')
                            .removeClass('hidden');
                        location ='#/';
                    })
        })
    });
}());
