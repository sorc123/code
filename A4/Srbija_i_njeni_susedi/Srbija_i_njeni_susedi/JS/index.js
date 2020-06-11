var slike = document.getElementsByClassName("slike");
var drzave = [];

var Srbija = "Glavni grad: Beograd\n\
Broj stanovnika: 7.186.862\n\
Povrsina: 88,499 km²\n\
Sluzbeni jezik: srpski";

var Hrvatska = "Glavni grad: Zagreb\n\
Broj stanovnika: 4.284.889\n\
Povrsina: 56.594 km2\n\
Sluzbeni jezik: hrvatski";

var Bugarska = "Glavni grad: Sofija\n\
Broj stanovnika: 7.245.677\n\
Povrsina: 110.994 km2\n\
Sluzbeni jezik: bugarski";

var Madjarska = "Glavni grad: Budimpesta\n\
Broj stanovnika: 9.879.000\n\
Povrsina: 93.027,44 km2\n\
Sluzbeni jezik: madjarski";

var CrnaGora = "Glavni grad: Podgorica\n\
Broj stanovnika: 620.029\n\
Povrsina: 13.812 km2\n\
Sluzbeni jezik: crnogorski";

var Albanija = "Glavni grad: Tirana\n\
Broj stanovnika: 2.821.977\n\
Povrsina: 28.748 km2\n\
Sluzbeni jezik: albanski";

var Rumunija = "Glavni grad: Bukurest\n\
Broj stanovnika: 19.511.000\n\
Povrsina: 238.391 km2\n\
Sluzbeni jezik: rumunski";

var BiH = "Glavni grad: Sarajevo\n\
Broj stanovnika: 3.531.159\n\
Povrsina: 51.209,2 km2\n\
Sluzbeni jezik: bosnjacki, srpski, hrvatski";

var Makedonija = "Glavni grad: Skoplje\n\
Broj stanovnika: 2.103.721\n\
Povrsina: 25.713 km2\n\
Sluzbeni jezik: makedonski";



for (var i = 0; i < slike.length; ++i)
{
    slike[i].addEventListener("click", function ()
    {
        var naziv = this.getAttribute('src').split("Slike/")[1].split(".")[0];
        window.alert(eval(naziv));
    })

    slike[i].addEventListener("mouseover", function ()
    {
        var naziv = "\\Muzika\\himna_" + this.getAttribute('src').split("Slike/")[1].split(".")[0] + ".mp3";
        var a = new Audio(naziv);
        a.currentTime = 0;
        a.play();

        this.addEventListener("mouseleave", function ()
        {
            a.pause();
        })
    })
}