$('form').on('submit', function (event) {
    event.preventDefault();

    var formData = {
        email: $("#email").val(),
        password: $("#password").val()
    }

    $.ajax({
        type: "POST",
        contentType: "application/json; charset=UTF-8",
        dataType: "json",
        data: JSON.stringify(formData),
        url: "https://localhost:7274/api/user",
        success: function (result) {
            if (result.response == 'OK')
                alert("Logado")
            else
                alert("Credencial incorreta")
        },
        error: function (result) {
            console.log(error);
        }

    })
});