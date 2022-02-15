var app = {}

app.totalFalhas = 0;
app.totalSucesso = 0;
app.chamadaSucesso = function () {
    let response = fetch('/home/sucesso').then(function (response) {
        app.tratarRetorno(response);
    });
}

app.chamadaProblema = function () {
    let response = fetch('/home/problema', {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
        },
        body: null,
    }).then(function (response) {
        app.tratarRetorno(response);
    });
}

app.tratarRetorno = function (response) {
    if (response.status != 200) {
        app.totalFalhas = ++app.totalFalhas;
    } else {
        app.totalSucesso = ++app.totalSucesso;
    }

    $("#div-totalsucesso").text(app.totalSucesso);
    $("#div-totalfalhas").text(app.totalFalhas)
}