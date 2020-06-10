var autobus = document.getElementById("autobus");
var dugme = document.getElementById("dugme");
var x = 15, y = 70;
var izabrano;

function novo_sediste(br_sedista)
{
    var sediste = document.createElement("div");
    var p = document.createElement("p");
    var tekst = document.createTextNode(br_sedista);
    p.appendChild(tekst);
    
    sediste.setAttribute("class", "sediste");
    
    sediste.style.top = y + "px";
    sediste.style.left = x + "px";

    sediste.appendChild(p);
    autobus.appendChild(sediste);

    sediste.addEventListener("click", function ()
    {
        var textbox = document.getElementById("brojsedista");
        textbox.value = this.childNodes[0].innerHTML;
        izabrano = this.childNodes[0].innerHTML;
    });

    if (br_sedista % 2 == 0)
    {
        x += 35;
    }
    else if ((br_sedista - 1) % 4 == 0) {
        x = 15;
        y += 35;
    }
    else
    {
        x += 70;
    }
    
    br_sedista++;
}

for (var i = 2; i <= 52; ++i)
{
    novo_sediste(i);
}

document.addEventListener("submit", function () {
        var sed = document.getElementsByClassName("sediste");

        for (var i = 0; i < sed.length; ++i) {
            if (sed[i].childNodes[0].innerHTML == izabrano) {
                sed[i].style.backgroundColor = "red";
                break;
            }
        }
        event.preventDefault();


});





