validator = (function(){
    function validatePassword(user) {
        var promise = new Promise(function (resolve, reject) {
            if (user.password === user.password2) {
                resolve()
            } else {
                reject()
            }

        })

        return promise;
    }

    return {
        password: validatePassword
    }
}())