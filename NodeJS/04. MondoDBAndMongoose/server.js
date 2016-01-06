"use strict";

var chatDb = require('./chat-db');


chatDb.init();

chatDb.registerUser({username: 'DonchoMinkov', password: '123456q'});
chatDb.registerUser({username: 'NikolayKostov', password: '123456q'});

chatDb.sendMessage({
    from: 'DonchoMinkov',
    to: 'NikolayKostov',
    text: 'Hey, Niki!'
});
chatDb.sendMessage({
    from: 'NikolayKostov',
    to: 'DonchoMinkov',
    text: 'Hey, Doncho!'
});

chatDb.getMessages({
    with: 'DonchoMinkov',
    and: 'NikolayKostov'
});