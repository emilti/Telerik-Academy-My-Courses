import 'bower_components/jquery/dist/jquery.js'
import Handlebars from 'bower_components/handlebars/handlebars.js'
// import {add , all, buId} from 'app/db.js'

import db from 'App/db.js'

var templateString  = '<li><strong>{{this}}</strong></li><li>check</li>'
var template = Handlebars.compile(templateString);

function add(){
    console.log('ADDD');
}

console.log('aaaa')
console.log(db.byId(2));
db.add({name: 'John'});
console.log(db.all())
function render(items){
    var $list = $('<ul />');
    items.map(template)
        .forEach(function(listItem){
            $list.append(listItem);
        })

    return $list;
}

export {
    render
    }