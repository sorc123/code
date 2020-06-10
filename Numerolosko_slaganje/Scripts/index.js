var dugme = document.getElementById("izracunaj");

function slaganje(datum) {
    var sum = 0;
    for (var i = 0; i < datum.length; ++i) {
        if (datum[i] != '.')
            sum += Number(datum[i]);
    }
    if (sum > 9) {
        sum = slaganje(sum.toString());
    }   
    return sum;
}

dugme.addEventListener("click", function ()
{
    document.getElementById("prva").innerHTML = document.getElementById("ime1").value;
    document.getElementById("druga").innerHTML = document.getElementById("ime2").value;
    var datum1 = document.getElementById("datum1").value;
    var datum2 = document.getElementById("datum2").value;
    var sum1 = 0;
    var sum2 = 0;

    if (datum1 != "" && datum2 != "")
    {
        sum1 = slaganje(datum1);
        sum2 = slaganje(datum2);
        document.getElementById("rezultat").innerHTML = "" + (sum1 / sum2 * 100) + "%";
    }
});


