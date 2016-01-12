var Movie = require('mongoose').model('Movie');

module.exports = {
    create: function(movie, callback){
        Movie.create(movie, callback)
    }
};