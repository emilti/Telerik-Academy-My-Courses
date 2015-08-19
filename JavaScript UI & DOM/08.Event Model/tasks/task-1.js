/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve() {
  return function GenerateEvents(selector) {
    var passedObject, i, j, m, element, elementsWithButtonClass, elementsWithContentClass, lenButtonClass;
    element = selector;
    if (selector.nodeName == false && typeof selector != 'string') {
      throw  new error('Passed parameter is not a dom element or string.');
    }

    if (typeof selector === 'string') {
      passedObject = document.getElementById(selector);
      if (passedObject === null) {
        throw  new error('The string does not represent real object.')
      }

      element = passedObject;
    }

    elementsWithButtonClass = element.querySelectorAll('.button');
    elementsWithContentClass = element.querySelectorAll('.content');
    for (i = 0, lenButtonClass = elementsWithButtonClass.length; i < lenButtonClass; i += 1) {
      elementsWithButtonClass[i].innerHTML = 'hide';
    }

    for (m = 0, lenButtonClass = elementsWithButtonClass.length; m < lenButtonClass; m += 1) {
        elementsWithButtonClass[m].addEventListener('click', onClick, false);
    }

    function onClick(event) {
      var clickedButton = event.target, nextContent, nextButton, currentElement, previousSiblingChecked = clickedButton,
          isContentFound = false, contentElement;
      do {
        currentElement = previousSiblingChecked.nextElementSibling;
        //console.log(currentElement)
        if (isContentFound === false && currentElement !== null &&
          currentElement.className === ('content')){//  currentElement.classList.contains('content'))
          contentElement = currentElement;
          isContentFound = true;
        }

        if (isContentFound === true && currentElement !== null &&
           currentElement.className === ('button')){//{ currentElement.classList.contains('button'))
          nextButton = currentElement;
          if (contentElement.style.display !== 'none'){
            contentElement.style.display = 'none';
            event.target.innerHTML = 'show';
          } else {
            contentElement.style.display = '';
            event.target.innerHTML = 'hide';
          }

          break;
        }

        previousSiblingChecked = currentElement;
      }
      while (currentElement !== null)
    };
  };
}

module.exports = solve;


var el = GenerateEvents('root');
console.log(el);