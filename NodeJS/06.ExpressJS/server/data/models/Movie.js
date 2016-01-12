'use strict';

var mongoose = require('mongoose');


module.exports.init = function() {
    var moviesSchema = mongoose.Schema({
        title: {type: String, required: '{PATH} is required'},
        description: {type: String },
        publisher:{ type: String, required: '{PATH} is required'},
        imageUrl: { type: String, require: '{PATH} is required', default: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTQOrSSvhefLVAXo3OOoMGYGS232bfHFnZyA9Jk24KeefYuau8c' },
        image: String
    });

    var Movie = mongoose.model('Movie', moviesSchema);
}

//module.exports.seedInitialItems = function(callback) {
//
//    Item.count({}, function (err, count) {
//        if (err) {
//            return console.log(err);
//        }
//
//        // if db is empty or we are in development mode -> seed
//        if (count == 0 || !process.env.NODE_ENV) {
//            seed(callback);
//        }
//    });
//};
//
//function seed(callback) {
//    Item.remove({}, function (err) {
//        if (err) return console.log(err);
//
//        Item.create(require('./items.json'), function (err) {
//            if (err) return console.log(err);
//
//            console.log('Database seeded with items...');
//
//            if (typeof(callback) === "function") {
//                callback();
//            }
//        });
//    });
//}
