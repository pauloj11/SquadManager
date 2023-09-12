$('form').on('submit', function (event) {
    event.preventDefault();

    $.ajax({
        type: "POST",
        contentType: "application/json; charset=UTF-8",
        dataType: "json",
        data: JSON.stringify($("#email").val()),
        url: "https://localhost:7274/api/user/forgot",
        success: function (result) {
            if (result.response == 'OK')
                alert("E-mail foi enviado para recuperar a senha")
            else
                alert("Erro inesperado")
        },
        error: function (result) {
            console.log(error);
        }

    })
});