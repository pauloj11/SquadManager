$('form').on('submit', function (event) {
    event.preventDefault();

    if ($("#password").val() != $("#confirmPassword").val()) {
        $(".error span").show();

        setTimeout(function () {
            $(".error span").hide();
        }, 3000)
        return;
    }

    var formData = {
        username: $("#username").val(),
        email: $("#email").val(),
        password: $("#password").val(),
        confirmPassword: $("#confirmPassword").val()

    }

    $.ajax({
        type: "POST",
        contentType: "application/json; charset=UTF-8",
        dataType: "json",
        data: JSON.stringify(formData),
        url: "https://localhost:7274/api/user/create",
        success: function (result) {
            if (result.response == 'OK')
                alert("Criado")
            else
                alert("Não foi possível criar")
        },
        error: function (result) {
            console.log(error);
        }

    })
});