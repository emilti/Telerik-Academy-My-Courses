var templates = (function(){
    var handlebars = window.handlebars || window.Handlebars
    var Handlebars = window.handlebars || window.Handlebars

    function get(name){
        var promise = new Promise(function(resolve, reject){
            var url=`templates/${name}.handlebars`;
            $.get(url, function(templateHtml){
                var template = handlebars.compile(templateHtml)
                resolve(template);
            })
        })

        return promise;
    }
    return {
        get: get
    }
}())