var data = (function(){
    var STORAGE_SESSION_KEY = 'SESSION_KEY',
        STORAGE_USERNAME_KEY = 'STORAGE_USERNAME_KEY',
        STORAGE_PASSWORD_KEY =  'STORAGE_PASSWORD_KEY';
    /*User*/
    function register(user){
        var promise = new Promise(function(resolve, reject){
            var url = '/user';
            var reqUser = {
                username: user.username,
                authCode: CryptoJS.SHA1(user.username + user.password).toString()
            }

            console.log(reqUser);

            $.ajax(url,{
                    method: 'POST',
                    contentType: 'application/json',
                    data: JSON.stringify(reqUser),
                    success: function(res){
                        localStorage.setItem(STORAGE_USERNAME_KEY, reqUser.username);
                        localStorage.setItem(STORAGE_PASSWORD_KEY, reqUser.password);
                        toastr.success('User registered');
                        resolve(res);
                    },
                    error:function(err){
                        toastr.error('Unsuccessful registration');
                        reject(err);
                    }
                }
            )
        });

        return promise
    }

    function login(user){
        var promise = new Promise(function(resolve, reject){
            var url = '/auth';
            var reqUser = {
                username: user.username,
                authCode: CryptoJS.SHA1(user.username + user.password).toString()
            }
            $.ajax(url,{
                method: 'POST',
                contentType: 'application/json',
                data: JSON.stringify(reqUser),
                success: function(res){
                     console.log(res);
                    localStorage.setItem(STORAGE_SESSION_KEY, res.sessionKey);
                    localStorage.setItem(STORAGE_USERNAME_KEY, reqUser.username);
                    localStorage.setItem(STORAGE_PASSWORD_KEY, reqUser.password);
                    toastr.success('User logged in');
                    resolve(res);
                },error:function(err){
                    toastr.error('Unsuccessful login');
                    reject(err);
                }
            })
        });

        return promise;
    }

    function logout(){
        var promise = new Promise(function(resolve, reject){
            var url = '/user';
            $.ajax(url,{
                method: 'PUT',
                contentType: 'application/json',
                headers: {
                    'X-SessionKey': localStorage.getItem(STORAGE_SESSION_KEY)
                },
                success: function(res){
                    localStorage.removeItem(STORAGE_SESSION_KEY);
                    localStorage.removeItem(STORAGE_USERNAME_KEY);
                    localStorage.removeItem(STORAGE_PASSWORD_KEY);
                    toastr.success('User log-out');
                    resolve(res);
                },error:function(err){
                    toastr.error('Unsuccessful log-out');
                    reject(err);
                }
            })
        });

        return promise;
    }

    function getAllPosts() {
        var promise = new Promise(function (resolve, reject) {
            var url = '/post';

            // var reqUser = {
            //    username: user.username,
            //    passHash: CryptoJS.SHA1(user.password).toString()
            // }

            //var authKey = 'undefined-D%kTENBHKjWr^K^Trx_lM-dE!VWqV-kymepJoQz!QBVCYYXK%$'
            $.ajax(url, {
                method: 'GET',
                contentType: 'application/json',
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



    function addPost(post){
        var promise = new Promise(function(resolve, reject){
            var url = '/post';

            $.ajax(url,{
                method: 'POST',
                contentType: 'application/json',
                data: JSON.stringify(post),
                headers: {
                    'X-SessionKey': localStorage.getItem(STORAGE_SESSION_KEY)
                },
                success: function(res){
                    toastr.success('Post added');
                    resolve(res);
                },error:function(err){
                    toastr.error('Unsuccessful login');
                    reject(err);
                }
            })
        });

        return promise;
    }

    return {
        users:{
            register: register,
            login: login,
            logout: logout
        },
        posts:{
            addPost: addPost,
            allPosts: getAllPosts
        }
    }
}())
