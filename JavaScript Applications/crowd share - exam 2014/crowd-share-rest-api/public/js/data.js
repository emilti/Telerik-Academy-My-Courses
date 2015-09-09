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
                        console.log(res);
                        toastr.success('User registered');
                        resolve(res);
                    },
                    error:function(err){
                        toastr.error('Unsuccessful registration');
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
                    //localStorage.setItem(STORAGE_SESSION_KEY, res)
                    toastr.success('User logged in');
                    resolve(res);
                }
            })
        });

        return promise;
    }

    return {
        users:{
            register: register,
            login: login
        }
    }
}())
