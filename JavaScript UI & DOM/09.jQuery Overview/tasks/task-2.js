/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/


function solve() {
  return function (selector) {

    if (selector === undefined || selector === null || (typeof selector !== 'string' && !(selector instanceof jQuery))) {
      throw new Error("Not a valid selector.");
    }

    $.fn.exists = function () {
      return this.length !== 0;
    }
    $(function () {
      if (typeof selector === 'string') {
        if (!($(selector).exists())) {
          throw new Error("Not a valid selector - does not exist.");
        }
      }
    });

    $('.button').html('hide');
    $('.button').click(function () {
      var $this = $(this);
      var $closestContent = $this.nextAll(".content:first");
      if ($closestContent.exists()) {
        var $nextButton = $closestContent.nextAll(".button:first");
        if ($nextButton.exists()) {
          if ($closestContent.css('display') != 'none') {
            $this.html('show');
            $closestContent.css('display', 'none');
          } else {
            $this.html('hide');
            $closestContent.css('display', '');
          }
        }
      }
    })
  };
}


module.exports = solve;