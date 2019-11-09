function apriChiudiMenu() {
    $(".menu").toggleClass("chiuso");
}

function eliminaSplash() {
    $(".splash").css("display", "none");
}


$("document").ready(function () {
    window.setTimeout(function () {
        eliminaSplash();
    }, 4000);
});


function seleziona(obj) {
    $(".selected").removeClass("selected");
    $(obj).addClass("selected");
}

function redirect() {
    var myId = $(".selected").attr("id");
    window.location = "/game/lobby/" + myId;
}