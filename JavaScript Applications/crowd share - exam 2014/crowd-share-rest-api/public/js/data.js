var data = (function(){
    var STORAGE_SESSION_KEY = 'SESSION_KEY';
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
                    localStorage.setItem(STORAGE_SESSION_KEY, res.sessionKey)
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
                    localStorage.removeItem(STORAGE_SESSION_KEY)
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

    return {
        users:{
            register: register,
            login: login,
            logout: logout
        }
    }
}())
