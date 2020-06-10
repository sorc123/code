window.addEventListener("load", load());

function load()
{
    var slike = document.getElementsByTagName("img");
    var indik = document.getElementsByClassName("kvadrat");
    var div = document.getElementById("slike");

    slike[0].style.visibility = "visible";

    var i = 1;
    var k = 0;

    setInterval(function () {
        switch (i) {
            case 1:
                k = 0;
                break;
            case 5:
                i = 0;
                break;
        }

        slike[i].style.visibility = "visible";
        slike[i].style.animation = "fadein 1s";
        slike[k].style.visibility = "hidden";
        slike[k].style.animation = "none";
        indik[i].style.backgroundColor = "rgb(180, 180, 180)";
        indik[k].style.backgroundColor = "rgb(116, 112, 112)";

        ++i;
        ++k;
    }, 3000);

}



