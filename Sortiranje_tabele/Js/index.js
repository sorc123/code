var tabela = document.getElementById("MojaTabela");
var smerRbr = false;
var smerIme = true;
var smerPrezime = true;

tabela.rows[0].cells[0].addEventListener("click", function () {
    smerIme = true;
    smerPrezime = true;
    if (smerRbr) {
        for (var i = 1; i < tabela.rows.length; ++i) {
            for (var k = i + 1; k < tabela.rows.length; ++k) {
                if (Number(tabela.rows[k].cells[0].innerText) < Number(tabela.rows[i].cells[0].innerText)) {
                    var temp;
                    for (var j = 0; j < 3; ++j) {
                        temp = tabela.rows[i].cells[j].innerText;
                        tabela.rows[i].cells[j].innerText = tabela.rows[k].cells[j].innerText;
                        tabela.rows[k].cells[j].innerText = temp;
                    }
                }
            }
        }

        smerRbr = false;
    }
    else
    {
        for (var i = 1; i < tabela.rows.length; ++i) {
            for (var k = i + 1; k < tabela.rows.length; ++k) {
                if (Number(tabela.rows[k].cells[0].innerText) > Number(tabela.rows[i].cells[0].innerText)) {
                    var temp;
                    for (var j = 0; j < 3; ++j) {
                        temp = tabela.rows[i].cells[j].innerText;
                        tabela.rows[i].cells[j].innerText = tabela.rows[k].cells[j].innerText;
                        tabela.rows[k].cells[j].innerText = temp;
                    }
                }
            }
        }

        smerRbr = true;
    }
    
});

tabela.rows[0].cells[1].addEventListener("click", function () {
    smerRbr = true;
    smerPrezime = true;
    if (smerIme) {
        for (var i = 1; i < tabela.rows.length; ++i) {
            for (var k = i + 1; k < tabela.rows.length; ++k) {
                if (tabela.rows[k].cells[1].innerText < tabela.rows[i].cells[1].innerText) {
                    var temp;
                    for (var j = 0; j < 3; ++j) {
                        temp = tabela.rows[i].cells[j].innerText;
                        tabela.rows[i].cells[j].innerText = tabela.rows[k].cells[j].innerText;
                        tabela.rows[k].cells[j].innerText = temp;
                    }
                }
            }
        }

        smerIme = false;
    }
    else {
        for (var i = 1; i < tabela.rows.length; ++i) {
            for (var k = i + 1; k < tabela.rows.length; ++k) {
                if (tabela.rows[k].cells[1].innerText > tabela.rows[i].cells[1].innerText) {
                    var temp;
                    for (var j = 0; j < 3; ++j) {
                        temp = tabela.rows[i].cells[j].innerText;
                        tabela.rows[i].cells[j].innerText = tabela.rows[k].cells[j].innerText;
                        tabela.rows[k].cells[j].innerText = temp;
                    }
                }
            }
        }

        smerIme = true;
    }

});

tabela.rows[0].cells[2].addEventListener("click", function () {
    smerRbr = true;
    smerIme = true;
    if (smerPrezime) {
        for (var i = 1; i < tabela.rows.length; ++i) {
            for (var k = i + 1; k < tabela.rows.length; ++k) {
                if (tabela.rows[k].cells[2].innerText < tabela.rows[i].cells[2].innerText) {
                    var temp;
                    for (var j = 0; j < 3; ++j) {
                        temp = tabela.rows[i].cells[j].innerText;
                        tabela.rows[i].cells[j].innerText = tabela.rows[k].cells[j].innerText;
                        tabela.rows[k].cells[j].innerText = temp;
                    }
                }
            }
        }

        smerPrezime = false;
    }
    else {
        for (var i = 1; i < tabela.rows.length; ++i) {
            for (var k = i + 1; k < tabela.rows.length; ++k) {
                if (tabela.rows[k].cells[2].innerText > tabela.rows[i].cells[2].innerText) {
                    var temp;
                    for (var j = 0; j < 3; ++j) {
                        temp = tabela.rows[i].cells[j].innerText;
                        tabela.rows[i].cells[j].innerText = tabela.rows[k].cells[j].innerText;
                        tabela.rows[k].cells[j].innerText = temp;
                    }
                }
            }
        }

        smerPrezime = true;
    }

});

