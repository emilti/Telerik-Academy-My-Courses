var express = require('express'),
    multer = require('multer');

var env = process.env.NODE_ENV || 'development';

var app = express();
var config = require('./server/config/config')[env];

require('./server/config/express')(app, config);
require('./server/config/mongoose')(config);
require('./server/config/passport')();

var storage = multer.diskStorage({
    destination: './public/images',
    filename: function(req, file, cb) {
        console.log(file);
        var ext = file.originalname.split('.')
            .pop();
        cb(null, file.fieldname + '-' + Date.now() + '.' + ext);
    }
});

var upload = multer({
    storage: storage
});

require('./server/config/routes')(app, upload);

app.listen(config.port);
console.log("Server running on port: " + config.port);