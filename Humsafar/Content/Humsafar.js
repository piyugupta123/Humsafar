$(document).ready(function () {
    GetHumsafar();
});
var SaveHumsafar = function () {
    var Name = $("#txtName").val();
    var City = $("#txtCity").val();
    var model = {
        Name: Name, City: City,
    };
    $.ajax({
        url: "/Humsafar/SaveHumsafar",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert = ("save successfully");

        }
    });
}

var GetHumsafar = function () {
    debugger;
    $.ajax({
        url: "/Humsafar/GetHumsafar",
        method: "post",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#tblHum tbody").empty();
            $.each(response.model, function (index, elementvalue) {
                html += "<tr><td>" + elementvalue.Id
                    + "</td><td>" + elementvalue.Name
                    + "</td><td>" + elementvalue.City
                    + "</td></tr>"
            });
            $("#tblHum tbody").append(html);
        }
    });
}