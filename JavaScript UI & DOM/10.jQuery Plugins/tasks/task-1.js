function solve() {
    return function (selector) {
        var $select = $(selector);
        var $div = $('<div/>').addClass('dropdown-list');
        $select.css('display', 'none')
        $($select).wrap($div);
        var optionsCount = $(selector + ' option').size();

        var values = $(selector + ">option").map(function () {
            return $(this).val();
        }).get();

        var $divOptionsContainer = $('<div/>').addClass('options-container')
            .css('position', 'absolute')
            .css('display', 'none');

        ($('<div/>').addClass('current').attr('data-value','').
            text($(selector + ' option[value=' + values[0] + ']').text())).
            appendTo('.dropdown-list');

        for (var i = 0; i < optionsCount; i += 1) {
            var index = i + 1;
            var valFromSelector = $(selector + ' option');
            $divOptionsContainer.append($('<div/>')
                .addClass('dropdown-item')
                .attr('data-value', values[i])
                .attr('data-index', i).html($(selector + ' option[value=' + values[i] + ']').text()));
        }

        $divOptionsContainer.appendTo('.dropdown-list');

        $('.current').click(function(){
            $select.css('display','block');
            $('.options-container').css('display','');
            $('.dropdown-item').click(function(ev){
                var $clicked = $(ev.target);
                $select.val($clicked.attr('data-value'));
                $select.css('display','none');
                $('.options-container').css('display','none');
                $('.current').html($(ev.target).text());
            })
        })
    };
}

module.exports = solve;