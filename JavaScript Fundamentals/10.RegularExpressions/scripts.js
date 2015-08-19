function problem1(form){
    var name = form.nameProblem1.value;
    var age = form.ageProblem1.value;
    var text = form.textProblem1.value;
    var options = {name:name, age:age},
        finalText;
    String.prototype.format = function( options){
        var formattedText = this;
        formattedText = this.replace(/#\{name}/g,options.name );
        formattedText = formattedText.replace(/#\{age}/g,options.age );
        return formattedText;
    }
    finalText = text.format(options);
    console.log(finalText);
}


function problem2(form){
    var name = form.nameProblem2.value;
    var link = form.linkProblem2.value;
    var text = form.textProblem2.value;
    var options = {name:name, link:link},
        finalText;
    String.prototype.bind = function( options){
        var formattedText = this;
        formattedText = this.replace(/><\//g," href=\"_href\"></" );
        formattedText = formattedText.replace(/_href/g,options.link);
        formattedText = formattedText.replace(/><\//g," class=\"_name\"></" );
        formattedText = formattedText.replace(/_name/g,options.name );
        formattedText = formattedText.replace(/><\//g,">_name</" );
        formattedText = formattedText.replace(/_name/g,options.name );
        return formattedText;
    }
    finalText = text.bind(options);
    console.log(finalText);
}
