validator = (function(){
    function validatePassword(user) {
            if (user.password === user.password2) {
              return true
            } else {
                return false;
            }
        }


    return {
        password: validatePassword
    }
}())