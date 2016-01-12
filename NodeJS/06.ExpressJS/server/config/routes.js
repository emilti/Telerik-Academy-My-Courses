var auth = require('./auth'),
    controllers = require('../controllers/index');

module.exports = function(app, upload) {
    app.get('/register', controllers.users.getRegister)
    app.post('/register', controllers.users.postRegister);

    app.get('/login', controllers.users.getLogin)
    app.post('/login', auth.login);
    app.get('/logout', auth.logout);

    app.get('/movies', controllers.movies.getAllMovies);
    app.get('/movies/:id', controllers.movies.getMovieById);

    app.get('/movies/:id/edit', auth.isOriginalCreator, controllers.movies.getMovieByIdForEdit);
    app.post('/movies/:id/edit', controllers.movies.updateMovie);

    app.get('/create-movie', auth.isAuthenticated, controllers.movies.getCreateMovie)
    app.post('/create-movie', auth.isAuthenticated, upload.single('image-file'), controllers.movies.createMovie)

    app.get('/unauthorized', controllers.users.unauthorized)

    app.get('*', function(req, res) {
        res.render('index', {currentUser: req.user});
    });
}