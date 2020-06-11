var instrumenti = document.getElementsByClassName("instrument");
var zvukovi = document.getElementsByClassName("zvucnik");
for (var i = 0; i < instrumenti.length; ++i)
{
    instrumenti[i].addEventListener("click", function () {
        window.location.href = "https://sh.wikipedia.org/wiki/" + this.alt;
    });

    zvukovi[i].addEventListener("mouseover", function () {
        var audio = new Audio("Muzika/" + this.alt + ".wav");
        audio.play();
    });
}