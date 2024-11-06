function StoresList(Id) {
    $.ajax({
        type: "Get",
        url: `../Store/SelectStore?id=${Id}`,
        processData: false,
        contentType: false,
        success: function (result) {

            $('#store').html(result);

        },
        error: function (result) {
            alert("error occured");
        }
    });
}