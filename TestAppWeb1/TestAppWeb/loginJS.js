function login()
{
    var user = document.getElementById("user").value;
    var pw = document.getElementById("pw").value;

        $.ajax({
            type: "GET",
            url: "/Controller/loginController",
            data: { user: user, pw: pw},
            success: function () {
                    alert("success");
            },
            error: function () {
                    alert("Some thing wrong..");
                }
        });
}

