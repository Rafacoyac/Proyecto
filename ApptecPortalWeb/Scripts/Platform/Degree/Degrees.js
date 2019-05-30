$(document).ready(function () {
    $('#SaveDegree').click(function () {
        var oModel = {
            "Nombre": $("#nombreGrado").val()
        }
        $.ajax({
            "async": true,
            "crossDomain": true,
            "cache": false,
            "method": "POST",
            "url": "http://localhost:59538/Api/Degree/Create",
            "data": JSON.stringify(oModel),
            "contentType": "application/json"
        }).done(function (response) {
            console.log(response)

        }).fail(function (jqXHR, textStatus, err) {
            console.log(textStatus)
        });
        alert("Ok");
    });
});




