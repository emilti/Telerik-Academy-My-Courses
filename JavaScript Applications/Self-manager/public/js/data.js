var data = (function(){
    var STORAGE_AUTH_KEY = 'SPECIAL_AUTHENTICATION_KEY'
    /*User*/
    function register(user){
        var promise = new Promise(function(resolve, reject){
            var url = 'api/users';
            var reqUser = {
                username: user.username,
                passHash: CryptoJS.SHA1(user.password).toString()
            }
            $.ajax(url,{
                    method: 'POST',
                    contentType: 'application/json',
                    data: JSON.stringify(reqUser),
                    success: function(res){
                        // console.log(res);
                        toastr.success('User registered');
                        resolve(res);
                    }
                }
            )
        });

        return promise
    }

    function login(user){
        var promise = new Promise(function(resolve, reject){
            var url = 'api/users/auth';
            var reqUser = {
                username: user.username,
                passHash: CryptoJS.SHA1(user.password).toString()
            }
            $.ajax(url,{
                    method: 'PUT',
                    contentType: 'application/json',
                    data: JSON.stringify(reqUser),
                    success: function(res){
                        //console.log(res.result.authKey);
                        localStorage.setItem(STORAGE_AUTH_KEY, res.result.authKey)
                        toastr.success('User logged in');
                        resolve(res);
                    }
                })
        });

        return promise;
    }

    function todosGet() {
        var promise = new Promise(function (resolve, reject) {
            var url = 'api/todos';

            // var reqUser = {
            //    username: user.username,
            //    passHash: CryptoJS.SHA1(user.password).toString()
            // }

            //var authKey = 'undefined-D%kTENBHKjWr^K^Trx_lM-dE!VWqV-kymepJoQz!QBVCYYXK%$'
            $.ajax(url, {
                method: 'GET',
                contentType: 'application/json',
                headers: {
                    'x-auth-key': localStorage.getItem(STORAGE_AUTH_KEY)
                },
                success: function (res) {
                    console.log(res);
                    resolve(res);
                },
                error: function(err){
                    reject(err);
                }
            });
        });

        return promise;
    }

    function todosAdd(todo){
        var promise = new Promise(function(resolve, reject){
            var url = 'api/todos';
            $.ajax(url,{
                contentType: 'application/json',
                method: 'POST',
                data: JSON.stringify(todo),
                headers: {
                    'x-auth-key': localStorage.getItem(STORAGE_AUTH_KEY)
                },
                success: function(res){
                    resolve(res);
                },
                error:function(err){
                  reject(err)
                }
            });
        });

        return promise;
    }

    function categoriesGet(){
        var promise = new Promise(function (resolve, reject) {
            var url = 'api/categories';
            $.ajax(url, {
                method: 'GET',
                contentType: 'application/json',
                headers: {
                    'x-auth-key': localStorage.getItem(STORAGE_AUTH_KEY)
                },
                success: function (res) {
                    //console.log(res);
                    resolve(res);
                },
                error: function(err){
                    reject(err);
                }
            });
        });

        return promise;

    }

    function todosUpdate(id, state){
        var promise = new Promise(function (resolve, reject) {
            //api/todos/:id
            //body ->
            // {{state}
            //console.log(id);
            // console.log(state);
            var url = 'api/todos/' + id;
            $.ajax(url,{
                contentType: 'application/json',
                method: 'PUT',
                data: JSON.stringify({state: state}),
                headers: {
                    'x-auth-key': localStorage.getItem(STORAGE_AUTH_KEY)
                },
                success: function(res){
                    resolve(res);
                },
                error:function(err){
                    reject(err)
                }
            });




    })

            return promise
    }

    return {
        users:{
            register: register,
            login: login
        },
        todos:{
            get: todosGet,
            add:todosAdd,
            update: todosUpdate
        },
        categories:{
            get:categoriesGet
        }
    }
}())
