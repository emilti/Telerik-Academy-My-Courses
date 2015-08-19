/* globals $ */

/* 

Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
  return function (selector, count) {
    var i, j, countLength;
    if (Array.isArray(selector) ||
        typeof selector === 'number' ||
        typeof selector === 'object' ||
        selector === undefined ){
      throw new Error("Not a valid selector.")
    }

    if (typeof count === 'string') {
      for (i = 0, countLength = count.length; i < count.length; i+=1){
        if (count.charAt(i) < '0' || count.charAt(i) > '9'){
          throw new Error("Passed parameter for count is not a number.")
        }
      }
    }

    if (typeof count === 'number' && count < 1){
      throw new Error('Count is less than 1.')
    }

    if (count === undefined || count === null || count ==='' || typeof  count === 'object'){
      throw new Error("count is missing.");
    }

    if (Array.isArray(count)){
      throw new Error("count is Array.");
    }

   var $ul = document.createElement('ul');
    $($ul).addClass('items-list');
    for (j = 0; j < count; j+=1){
      var $liElement = document.createElement('li');
      $($liElement).addClass('list-item');
      $($liElement).html('List item #'+j);
      $($ul).append($liElement);
    }
    $(selector).append($ul);


  };
};

module.exports = solve;