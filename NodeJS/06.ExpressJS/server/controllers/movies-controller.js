'use strict';

var fs = require("fs");
var formidable = require('formidable');
var Movie = require('mongoose').model('Movie');
var movies = require('../data/movies');

var DEFAULT_UPLOAD_DIRECTORY = './public/images';

module.exports = {
    getAllMovies: function (req, res, next) {
        Movie.find({})
        .select('title description publisher imageUrl image')
        .exec(function (error, collection) {
            if (error) {
                console.error('Error getting items: ' + error);
            } else {
                res.render('movies/all-movies', { result: collection, currentUser: req.user });
            }
        });
    },
    getMovieById: function (req, res, next) {
        Movie.findOne({ _id: req.params.id })
            .select('title description publisher imageUrl image')
            .exec(function (err, movie) {
                if (err) {
                    res.status(400).send('Item could not be loaded: ' + err);
                    console.log('Item could not be loaded: ' + err);
                    return;
                }

                console.log(movie)

                var isMatchUser = false;
                if(req.user != undefined && movie.publisher.localeCompare(req.user.username.toString()) === 0){
                    isMatchUser = true
                }
                else if(req.user != undefined){
                    isMatchUser = false;
                }
                else{
                    res.redirect('/login');
                }

                res.render('movies/detailed-movie', {currentUser: req.user, viewedMovie: movie, matchedUser: isMatchUser})
            });
    },
    getMovieByIdForEdit: function (req, res, next) {
        Movie.findOne({ _id: req.params.id })
            .select('title description publisher')
            .exec(function (err, movie) {
                if (err) {
                    res.status(400).send('Item could not be loaded: ' + err);
                    console.log('Item could not be loaded: ' + err);
                    return;
                }

                res.render('movies/detailed-movie-for-edit', {currentUser: req.user, viewedMovie: movie})
            });
    },
    getCreateMovie: function (req, res, next) {
        res.render('movies/create-movie', {currentUser: req.user})
    },
    createMovie: function (req, res, next) {

        console.log(req.body);
        var reqMovie = req.body;

        if (!reqMovie.image && req.file) {
            reqMovie.image = req.file.path.substr('public'.length);
        }

        var newMovie =
            {
                title: req.body.title,
                description: req.body.description,
                imageUrl: req.body.imageUrl,
                publisher: req.user.username.toString(),
                image: reqMovie.image
            }

           movies.create(newMovie, function (err, movie) {
                if (err) {
                    res.status(400).send(err);
                    return;
                }

                res.redirect('/');

                // res.status(201).send(movie);
            });

    },
    updateMovie: function (req, res, next) {
       var updatedMovieData = {
            title: req.body.title,
            description: req.body.description
        };

        Movie.findById(req.params.id, function(err, movie) {
            if (!movie)
                return next(new Error('Could not load Document'));
            else {

                movie.title = updatedMovieData.title;
                movie.description = updatedMovieData.description;


                movie.save(function(err) {
                       res.redirect('/movies/' + req.params.id)
                });
            }
        });
    }
};