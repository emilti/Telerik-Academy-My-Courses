function solve(){
  return function(){
    $.fn.listview = function(data){
      var elements = document.getElementsByTagName('*'), elementWithTemplate;
      for (var i = 0; i < elements.length; i+=1){
        var initialResult = elements[i].getAttribute("data-template");

        if (initialResult !== null){
          elementWithTemplate = elements[i];
          var id = initialResult;
          break;
        }
      }

      var html = $('#' + id).html();
      output = '';
      for (var i = 0, len = data.length; i< len; i+=1){
        var compiledTemplate = handlebars.compile(html);
        var output = output + compiledTemplate(data[i]);
      }

      elementWithTemplate.innerHTML = output;
    };
  };
}

module.exports = solve;