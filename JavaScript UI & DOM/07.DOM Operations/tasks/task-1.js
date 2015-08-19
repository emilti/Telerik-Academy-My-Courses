/* globals $ */

/*

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed
*/


module.exports = function solve() {
  return function GenerateDom(element, contents) {
    var passedObject, len = contents.length, i, j;
    if (element.nodeName == false && typeof element != 'string' ){
       throw  new error('Passed parameter is not a dom element or string.');
    }

    if (typeof element === 'string'){
      passedObject = document.getElementById(element);
      if (passedObject === null){
        throw  new error('The string does not represent real object.')
      }
      element = passedObject;
    }

    if (contents === undefined || contents === null){
      throw new Error('No content passed.')
    }

    for (i = 0; i < len; i+= 1){
      if (typeof contents[i] !== 'number' && typeof contents[i] !== 'string'){
        throw new Error;
      }
    }

    var div = document.createElement('div');
    var divFragment = document.createDocumentFragment();
    for (j = 0; j < len; j+=1){
      var clonedDiv = div.cloneNode(true);
      clonedDiv.innerHTML = contents[j];
      divFragment.appendChild(clonedDiv);
    }

    element.innerHTML = '';
    element.appendChild(divFragment);
    return element
  };
}



//var el = GenerateDom('example', ['aa', 'bb']);
//console.log(el);
