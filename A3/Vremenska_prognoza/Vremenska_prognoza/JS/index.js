var izbor = document.getElementById("izbor");
var prognoza = document.getElementsByTagName("iframe");

izbor.addEventListener("change", function ()
{
    prognoza[0].setAttribute("src", this.value);
})