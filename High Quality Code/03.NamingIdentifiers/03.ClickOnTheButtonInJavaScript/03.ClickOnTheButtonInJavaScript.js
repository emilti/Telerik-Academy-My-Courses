function CheckBrowser( event, argumenti) {
    "use strict";
    var currentWIndow= window,
        currentBrowser = currentWIndow.navigator.appCodeName,
        isBrowserMozilla=currentBrowser === "Mozila";
    if(isBrowserMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}
