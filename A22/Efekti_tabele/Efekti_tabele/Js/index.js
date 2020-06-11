var tabela = document.getElementById("Tabela");
var sortiraj = document.getElementById("ButtonSortiraj");
var oboji = document.getElementById("ButtonOboji");
var markiraj_da = document.getElementById("ButtonMarkirajDa");
var markiraj_ne = document.getElementById("ButtonMarkirajNe");
var izdvoji = document.getElementById("ButtonIzdvoji");

sortiraj.addEventListener("click", sort);

oboji.addEventListener("click", function () {
    for (var i = 1; i < tabela.rows.length; ++i)
    {
        if (i % 2 == 1)
            tabela.rows[i].style.backgroundColor = "gray";
    }
});

markiraj_da.addEventListener("click", function () {
    for (var i = 1; i < tabela.rows.length; ++i) {
        if (Number(tabela.rows[i].cells[4].innerText) > 50)
            tabela.rows[i].style.backgroundColor = "green";
    }
});

markiraj_ne.addEventListener("click", function () {
    for (var i = 1; i < tabela.rows.length; ++i) {
        if (Number(tabela.rows[i].cells[4].innerText) < 50)
            tabela.rows[i].style.backgroundColor = "red";
    }
});

izdvoji.addEventListener("click", function () {
    for (var i = 1; i < tabela.rows.length; ++i) {
        if (Number(tabela.rows[i].cells[4].innerText) < 50) {
            tabela.deleteRow(i--);
        }
    }

    sort();
});

function sort() {
    for (var i = 1; i < tabela.rows.length; ++i) {
        for (var j = i + 1; j < tabela.rows.length; ++j) {
            if (Number(tabela.rows[j].cells[0].innerText) < Number(tabela.rows[i].cells[0].innerText)) {
                var temp;
                for (var k = 0; k < tabela.rows[0].cells.length; ++k) {
                    temp = tabela.rows[j].cells[k].innerText;
                    tabela.rows[j].cells[k].innerText = tabela.rows[i].cells[k].innerText;
                    tabela.rows[i].cells[k].innerText = temp;
                }
            }
        }
    }
}