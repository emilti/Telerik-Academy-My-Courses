/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * // method removeAttribute(attribute)
 */


/* Example

 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');

 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)

 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');

 div.content = 'Hello, world!';

 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'cuki')
 .addAttribute('bgcolor', '#012345');

 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);

 console.log(root.innerHTML);
 Outputs:
 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */


function solve() {

    var domElement = (function () {
        var domElement = {};
        function validateType(type){
            if (type.match(/^[a-zA-Z0-9]+$/) === null){
                throw new Error;
            }
        }
        function validateAttributeName(type){
            if (type.match(/^[a-zA-Z0-9\-]+$/) === null){
                throw new Error;
            }
        }

        Object.defineProperties(domElement,{
            init: {
                value: function (type) {
                this.type = type;
                this.attributes = [];
                this.result = '';
                this.isFromChild = false;
                this.content = '';
                this.parent = {};
                this.children = [];
                this.visited = false;
                return this;
                }
            },
            type: {
                get: function () {
                    return this._type;
                },
                set: function (type) {
                    validateType(type);
                    this._type = type;
                }
            },
            content: {
                get: function () {
                    return this._content;
                },
                set: function (content) {

                    this._content = content;
                }
            },
            parent:{
                get: function () {
                    return this._parent;
                },
                set: function (parent) {

                    this._parent = parent;
                }
            },
            visited: {
                get: function () {
                    return this._visited;
                },
                set: function (value) {
                    this._visited = value;
                }
            },
            appendChild:{
                value: function (child) {
                    if (typeof child === "object") {
                        this.children.push(child);
                        child.parent = this;
                    } else {
                        this.children.push(child);
                    }
                    return this;
                }
            },
            addAttribute: {
                value: function (name, value) {
                    validateAttributeName(name);
                    if (this.attributes.length > 0) {
                        for (var attributeCheckCount = 0; attributeCheckCount < this.attributes.length; attributeCheckCount += 1) {
                            if (this.attributes[attributeCheckCount].attributeName === name) {
                                this.attributes.splice(attributeCheckCount, 1);
                            }
                        }
                    }
                    this.attributes.push({attributeName: name, attributeContent: value});
                    function compare(a, b) {
                        if (a.attributeName < b.attributeName)
                            return -1;
                        if (a.attributeName > b.attributeName)
                            return 1;
                        return 0;
                    }

                    this.attributes.sort(compare);
                    return this;
                }
            },
            removeAttribute: {
                value: function (attributeForRemoving) {
                    if (this.attributes.length > 0) {
                        for (var attributeCheckCount = 0; attributeCheckCount < this.attributes.length; attributeCheckCount += 1) {
                            if (this.attributes[attributeCheckCount].attributeName === attributeForRemoving) {
                                this.attributes.splice(attributeCheckCount, 1);
                                break;
                            }
                            if (attributeCheckCount === this.attributes.length - 1) {
                                throw new Error;
                            }
                        }
                    } else {
                        throw new Error;
                    }
                    return this;
                }
            },
            innerHTML: {
                get: function () {
                    var end = '',
                        obj = this,
                        front = '',
                        self = this, startObject = this;
                    obj.result = (function getText(currentObject) {

                        function getFront() {
                            front = front + '<' + currentObject.type
                            for (var attributeCounter = 0, len = currentObject.attributes.length; attributeCounter < len; attributeCounter += 1) {
                                front = front + ' ' + currentObject.attributes[attributeCounter].attributeName + '="' + currentObject.attributes[attributeCounter].attributeContent + '"';
                            }

                            front = front + '>';
                            return front;
                        }

                        if ((currentObject.visited === false &&
                            currentObject.children.length === 0)) {
                            front = getFront();
                            end = '</' + currentObject.type + '>' + end;
                            currentObject.result = front + currentObject.content + end;
                            //
                            front = '';
                            end = '';
                            currentObject.visited = true;
                            return currentObject.result;
                        } else {
                            for (var childrenCounter = 0, numberOfChildren = currentObject.children.length; childrenCounter < numberOfChildren; childrenCounter += 1) {
                                if (typeof currentObject.children[childrenCounter] === "object") {
                                    currentObject.result = currentObject.result + getText(currentObject.children[childrenCounter]);
                                } else {
                                    currentObject.result = currentObject.result + currentObject.children[childrenCounter];
                                }
                                if (childrenCounter === currentObject.children.length - 1) {
                                    end = '</' + currentObject.type + '>' + end;
                                    front = getFront();
                                    currentObject.result = front + currentObject.result + end;
                                    front = '';
                                    end = '';
                                    currentObject.visited = true;
                                    return currentObject.result;
                                }

                            }
                        }
                    }(obj));
                    return obj.result;
                }
            }
        });

        return domElement;
    } ());
    return domElement;
}
module.exports = solve;

//var meta = Object.create(domElement)
//	.init('meta')
//	.addAttribute('charset', 'utf-8');
//
//var head = Object.create(domElement)
//	.init('head')
//	.appendChild(meta)
//
//var div = Object.create(domElement)
//	.init('div')
//	.addAttribute('style', 'font-size: 42px');
//
//div.content = 'Hello, world!';
//
//var body = Object.create(domElement)
//	.init('body')
//	.appendChild(div)
//	.addAttribute('id', 'cuki')
//	.addAttribute('bgcolor', '#012345');
//
//var root = Object.create(domElement)
//	.init('html')
//	.appendChild(head)
//	.appendChild(body);
//
//
//console.log(root.innerHTML);
//



//it('expect correct HTML when having both string and domElement children', function() {
//	var text = 'the text you SEE!',
//		root = Object.create(domElement).init('p'),
//		child1 = Object.create(domElement).init('b'),
//		child2 = Object.create(domElement).init('s');
//	root.appendChild(text);
//	root.appendChild(child1);
//	root.appendChild(text);
//	root.appendChild(child2);
//	root.appendChild(text);
//	console.log(root.innerHTML)
//.to.eql('<p>' + text + '<b></b>' + text + '<s></s>' + text + '</p>');
//});
//Object.create(domElement).init('hi');
//Object.create(domElement).init('hello!');












































