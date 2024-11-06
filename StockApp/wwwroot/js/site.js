//// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
//// for details on configuring this project to bundle and minify static web assets.

//// Write your JavaScript code.


//$(document).ready(function () {
//   $('#item').attr('disabled', true);
//    $('#store').attr('disabled', true);
//    Loaditems();
//});
//$('#item').change(function () {
//    var itemId = $(this).val();
//    if (itemId > 0) {
//        Loaditems(itemId);
//    }
//})

//function Loaditems(itemId) {
//    $('#item').empty();
//    $.ajax({
//        method: 'GET',
//        url: `/StockManagement/getItems?id=${itemId}`,
//        success: function (response) {
//            if (response != null && response != undefined && response.length > 0) {
//                $('#item').attr('disabled', false);
//                $('#item').appene('<option> Select Item</option>');
//                $('#store').appene('<option> Select Store</option>');
//                $.each(response, function (i, data) {
//                    $('#item').append('<option value=' + data.id + '>' + data.name + '</option>')
//                })
//            }
//        },
//        error: function (error) {
//            alert(error);
//        }
//    });


//}