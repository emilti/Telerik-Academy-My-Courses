var usersController = (function(){
    function register(context){
        templates.get('register')
            .then(function(template){
                context.$element().html(template());
                $('#btn-register').on('click', function(){
                    var user = {
                        username: $('#tb-register-username').val(),
                        password: $('#tb-register-password1').val(),
                        password2: $('#tb-register-password2').val()
                    };

                    validator.password(user)
                        .then(data.users.register(user)
                       ,function() {
                            toastr.error('Password is wrong');
                        })
                        .then(function(res){

                        })

                });
            });
    }

    function login(context){
        templates.get('login')
            .then(function(template){
                context.$element().html(template());
                $('#btn-login').on('click', function(){
                    var user = {
                        username: $('#tb-login-username').val(),
                        password: $('#tb-login-password').val()
                    };

                    console.log(user);
                    data.users.login(user)
                        .then(function(){
                            // console.log('User logged-in') ;
                            context.redirect('#/')
                        })
                });

            });
    }




    return {
        register: register,
        login: login
    }
}());

