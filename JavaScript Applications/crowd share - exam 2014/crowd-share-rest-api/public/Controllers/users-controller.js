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

                    if (validator.password(user) === true) {
                        data.users.register(user)
                            .then(function (res) {
                                $('#btn-go-to-login')
                                    .addClass('hidden');
                                $('#btn-go-to-register')
                                    .addClass('hidden');
                                $('#btn-logout').removeClass('hidden');
                                context.redirect('#/')
                                // document.location.reload(true);


                            })
                    } else {
                        toastr.error('Invalid password confirmation');
                    }

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

                    data.users.login(user)
                        .then(function(){
                            // console.log('User logged-in') ;
                            // document.location.reload(true);
                            $('#btn-go-to-login')
                                .addClass('hidden');
                            $('#btn-go-to-register')
                                .addClass('hidden');
                            $('#btn-logout').removeClass('hidden');
                            context.redirect('#/')


                        })
                });

            });
    }



    function getCurrentUser(){
        var sessionKey = localStorage.getItem('SESSION_KEY');
        if (!sessionKey){
            return null;
        }

        return {
            sessionKey: sessionKey
        }
    }




    return {
        register: register,
        login: login,
        current: getCurrentUser
    }
}());

