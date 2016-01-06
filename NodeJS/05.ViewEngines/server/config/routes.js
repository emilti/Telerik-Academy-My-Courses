var HomeController = require('../controllers/home-controller'),
    SmartphonesController = require('../controllers/smartphones-controller'),
    TabletsController = require('../controllers/tablets-controller'),
    WearablesController = require('../controllers/wearables-controller');


module.exports = function(app) {
    app.get('/home', HomeController.getHome);
    app.get('/smartphones', SmartphonesController.getSmartphones);
    app.get('/tablets', TabletsController.getTablets);
    app.get('/wearables', WearablesController.getWearables);
}
