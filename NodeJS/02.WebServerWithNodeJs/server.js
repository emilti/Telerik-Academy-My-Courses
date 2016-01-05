var formidable = require('formidable'),
    http = require('http'),
    util = require('util'),
    fs   = require('fs-extra'),
    Guid = require('Guid');

    http.createServer(function(req, res) {
        /* Process the form uploads */
        var id;
        if (req.url == '/upload' && req.method.toLowerCase() == 'post') {
            var form = new formidable.IncomingForm();
            form.parse(req, function(err, fields, files) {
                res.writeHead(200, {'content-type': 'text/html'});
                res.write('received upload\n\n');
                id = Guid.raw();
                res.end();
            });

            form.on('end', function(fields, files) {
                /* Temporary location of our uploaded file */
                var temp_path = this.openedFiles[0].path;
                /* The file name of the uploaded file */
                var filename = this.openedFiles[0].name;
                var wholeFilename = filename.split('.');
                var extension = wholeFilename[1];
                var formattedName = id + '.' + extension;

                /* Location where we want to copy the uploaded file */
                var new_location = './localhost/nodejs/';

                fs.copy(temp_path, new_location + formattedName, function(err) {
                    if (err) {
                        console.error(err);
                    } else {
                        console.log("success!")
                     }
                });
            });

            return;
        }

        if (req.url.indexOf('/download') > -1){
            var fileNameQuery = req.url.substring(req.url.lastIndexOf('/') + 1);
            var fileNamePath = './localhost/nodejs/' + fileNameQuery;
            console.log(fileNamePath);
            fs.readFile(fileNamePath, function (err, data) {
                if (!fs.existsSync('./downloads/')){
                    fs.mkdirSync('./downloads/');
                }

                fs.writeFile('./downloads/' + fileNameQuery, data, function (err) {
                    if (err) throw err;
                    console.log('It\'s downloaded!');
                });
            });

            res.writeHead(301, { location: '/' });
            res.end();
        }

        /* Display the file upload form. */
        res.writeHead(200, {'content-type': 'text/html'});
        res.end(
            '<form action="/upload" enctype="multipart/form-data" method="post" id="form">'+
            '<input type="file" name="upload" multiple="multiple"><br>'+
            '<br/>' +
            '<input type="submit" value="Upload">'+
            '</form>'
        );
    }).listen(8080);




