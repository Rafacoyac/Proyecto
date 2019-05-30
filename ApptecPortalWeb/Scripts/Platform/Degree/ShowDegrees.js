$(document).ready(function () {
    $('#Degree').DataTable({
        "ajax": {
            "method" : "POST",
            "url": "http://localhost:59538/Api/Degree/Show",
            "dataSrc": ""
        },
        "columns": [
            { "data": "nombre" },
            { "default":"dfgh"}
        ]
    });
});
