var passport = require('passport');
var Movie = require('mongoose').model('Movie');

module.exports = {
    login: function(req, res, next) {
        var auth = passport.authenticate('local', function(err, user) {
            if (err) return next(err);
            if (!user) {
                res.send({success: false})
            }

            req.logIn(user, function(err) {
                if (err) return next(err);
                res.redirect('/');
            })
        });

        auth(req, res, next);
    },
    logout: function(req, res, next) {
        req.logout();
        res.redirect('/');
    },
    isAuthenticated: function(req, res, next) {
        if (!req.isAuthenticated()) {
            res.redirect('/login');
        }
        else {
            next();
        }
    },
    isOriginalCreator: function(req, res, next){
        if(req.isAuthenticated()) {
            currentUser = req.user._id.toString();
            queryString = req.params.id.toString();
        }

        Movie.findOne({ _id: req.params.id })
            .select('title description publisher')
            .exec(function (err, movie) {
                if (err) {
                    res.status(400).send('Item could not be loaded: ' + err);
                    console.log('Item could not be loaded: ' + err);
                    return;
                }

                console.log(movie.publisher)

                if(movie.publisher.localeCompare(req.user.username.toString()) === 0){
                    next();
                } else{
                    res.redirect('/unauthorized');
                }
            });
    }
}