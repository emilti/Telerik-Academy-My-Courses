var UserController,
    MessageController,
    settings = require('./db-settings');

module.exports = {
    init: function () {
        require('./server/config/mongoose')(settings.development.db);
        UserController = require('./server/controllers/user-controller');
        MessageController = require('./server/controllers/message-controller');
    },
    registerUser: function (user) {
        UserController.registerUser(user);
    },
    sendMessage: function (messageData) {
        MessageController.sendMessage(messageData);
    },
    getMessages: function (messageData) {
        MessageController.getAllMessages(messageData, function (messages) {
            console.log(messages.join('\n\n'));
        });
    }
};