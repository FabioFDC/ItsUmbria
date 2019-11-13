function apriChiudiMenu() {
    $(".menu").toggleClass("chiuso");
}

function eliminaSplash() {
    $(".splash").css("display", "none");
}


$("document").ready(function () {
    //window.setTimeout(function () {
    //    eliminaSplash();
    //}, 4000);
});


function seleziona(obj) {
    $(".selected").removeClass("selected");
    $(obj).addClass("selected");
}

function redirect() {
    var myId = $(".selected").attr("id");
    window.location = "/game/lobby/" + myId;
}

function mostraPopuppino() {
    $(".popuppino").css("display", "block");
}

function callToCreate() {
    var heroName = $("#heroName").val();
    var heroClass = $("#heroClass").val();
    var heroColor = $("#heroColor").val();

    var payload = {
        HeroName: heroName,
        HeroClass: heroClass,
        HeroColor: heroColor
    }

    $.post("/game/createHero", payload).done(
        function (data) {
            if (data) {
                alert("eroe aggiunto correttamente");
            } else {
                alert("errore nella creazione eroe da server api");
            }
        }
    ).fail
        (function (data) {
            alert("errore nella creazione eroe");
        }
    );
}