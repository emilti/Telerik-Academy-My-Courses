var todosController = (function(){
    function all(context){
        var category = context.params.category;
        if (category){
            category = category.toLowerCase();
        }
        var todos;
        data.todos.get()
            .then(function(resTodos){
                todos = resTodos.result;
                console.log(resTodos.result);
               return templates.get('todos')
            })
            .then(function(template){
                groups = _.chain(todos)
                    .groupBy('category')
                    .map(function(todos, categoryName){
                        return {
                            category: categoryName,
                            todos: todos
                        };
                    })
                    .filter(function(group){
                        toastr.info(group.category);
                        return !category || group.category.toLowerCase() === category
                    })
                    .value();
                // console.log(groups)
                context.$element().html(template(groups));

            $('.todo-state').on('change', function(){
                var id = $(this).parents('.todo-item').attr('data-id');
                // console.log(id) ;
                var state = !!$(this).prop('checked');
                console.log(state);
                data.todos.update(id, state)
                    .then(function(){
                         toastr.success('State updated')
                    })  ;
            })
                    //$('#tb-todo-category').autocomplete({
                    //   source: ['Home', 'Not Home']
                    //})

            });
    }

    function add(context){
        templates.get('todos-add')
            .then(function(template){
                  context.$element().html(template());

                $('#btn-todo-add').on('click', function(){
                    var todo = {
                        text: $('#tb-todo-text').val(),
                        category:  $('#tb-todo-category').val()
                    }
                    console.log(todo);
                    data.todos.add(todo)
                        .then(function(todo){
                            var todo = todo.result;
                            toastr.success('TODO ' + todo.text + ' Added!')    ;
                            context.redirect('/#todos')
                        });
                });
                return data.categories.get()
            })
            .then(function(categories){
                $('#tb-todo-category').autocomplete({
                    source: categories.result
                })
           })
    }

    return {
        all: all,
        add: add
    }
}());
