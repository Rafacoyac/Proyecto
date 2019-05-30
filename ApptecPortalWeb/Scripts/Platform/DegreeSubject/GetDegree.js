$(document).ready(function () {
    /*  $.ajax({
          "async": true,
          "crossDomain": true,
          "cache": false,
          "method": "POST",
          "url": "http://localhost:59538/Api/DegreeSubject/Show",
          "data": JSON.stringify(oModel),
          "contentType": "application/json"
      }).done(function (response) {
          console.log(response)
  
      }).fail(function (jqXHR, textStatus, err) {
          console.log(textStatus, err, jqxr)
      });
      alert("Ok");
  });
  */
    /*
   $.ajax({
        //"async": true,
        //"crossDomain": true,
        //"cache": false,
        url: 'http://localhost:59538/Api/DegreeSubject/Show',
        Type: 'POST',
        dataType: 'json',
        success: function (data) {
            var c = $("#gradoId");
            var datos = data.data;
            $(datos).each(function (value) {
                c.append($("<option></option>").val(value.id).html(value.nombre));
            });
        },
        error: function () {
            console.log('err')
        }
    });
    */

    $.ajax({
        "async": "true",
        "crossDomain": "true",
        "cache": "false",
        "method": "POST",
        "contentType": "aplication/json; charset=utf-8",
        "url": "http://localhost:59538/Api/DegreeSubject/Show",
        "data": "{}",
        "dataType": "json",
        "success": function (result) {
            $('#gradoId').append("<option value='0'>--Seleccionar--</option>");
            $.each(result.d, function (key, value) {
                $("#gradoId").append($("<option></option>").val(value.id).html(value.nombre));
            });
        },
        error: function ajaxError(result) {
            console.log(result.status + ':' + result.statusText);
        }

    });

});
