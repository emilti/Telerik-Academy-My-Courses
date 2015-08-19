function lexFinder() {

    var prop,
        list = [];

    for (prop in document) {
        list.push(prop);
    }
    list.sort();
    alert('First in lexicographic order in document object: ' + list[0]);
    alert('Last in document object is: ' + list[list.length - 1]);

    for (prop in window) {
        list.push(prop);
    }

    alert('First in lexicographic order in document object: ' + list[0]);
    alert('Last in document object is: ' + list[list.length - 1]);

    for (prop in navigator) {
        list.push(prop);
    }

    alert('First in lexicographic order in document object: ' + list[0]);
    alert('Last in document object is: ' + list[list.length - 1]);
}
