var usersController = (function(){
    function register(context){
        templates.get('register')
            .then(function(template){
            context.$element().html(template());
            $('#btn-register').on('click', function(){
               var user = {
                   username: $('#tb-username').val(),
                   password: $('#tb-password').val()
               };

                data.users.register(user)
                    .then(function(){
                        console.log('User registered')
                    })
            });

            $('#btn-login').on('click', function(){
                var user = {
                    username: $('#tb-username').val(),
                    password: $('#tb-password').val()
                };

                data.users.login(user)
                    .then(function(){
                        // console.log('User logged-in') ;
                        context.redirect('#/')
                    })
            });

        });
    }



    return {
        register: register
    }
}());

