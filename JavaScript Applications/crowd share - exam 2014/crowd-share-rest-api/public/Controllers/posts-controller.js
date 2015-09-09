var postsController = (function(){
    function all(context){
        var posts;
        data.posts.allPosts()
            .then(function(resPosts){
                posts = resPosts
                // console.log('here' + posts);
                return templates.get('posts')
            }) .then(function(template){


                context.$element().html(template(posts));


            });



    }

    function add(context){
        templates.get('addPost').then(function(template){
            context.$element().html(template());
            $('#btn-add-post').on('click', function() {
                var post = {
                    title: $('#tb-post-title').val(),
                    body: $('#tb-post-body').val()
                };

                data.posts.addPost(post)
                    .then(function () {

                    })
            })

        })
    }

    return {
        all: all,
        add: add
    }
}())
