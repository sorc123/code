var slike = document.getElementsByClassName("slike");
var glavna = document.getElementById("glavna");
var naziv = document.getElementById("naziv");

for (var i = 0; i < slike.length; ++i)
{
    slike[i].addEventListener("click", function () {
        var temp = glavna.getAttribute('src');
        glavna.setAttribute('src', this.getAttribute('src'));
        this.setAttribute('src', temp);
        naziv.innerText = glavna.getAttribute('src').split("Slike/")[1];
    });
}