   $(document).ready(function () {
  
       Loaditems();
       LoadStores();
});


function Loaditems() {
   
    $.ajax({
        url: `/StockManagement/SelectItems`,
        success: function (result) {
          
                $.each(result, function (i, data) {
                    $('#item').append('<Option value=' + data.id + '>' + data.name + '</Option>')
                })
         
        },
        error: function (error) {
            alert(error);
        }
    });


}
function LoadStores() {

    $.ajax({
        url: `/StockManagement/SelectStores`,
        success: function (result) {

            $.each(result, function (i, data) {
                $('#store').append('<Option value=' + data.id + '>' + data.name + '</Option>')
            })

        },
        error: function (error) {
            alert(error);
        }
    });


}


 // if (response != null && response != undefined && response.length > 0) {
             //   $('#item').attr('disabled', false);
/* $('#item').append('<Option>Select Item</Option>');*/
               // $('#store').appene('<option> Select Store</option>');

//$(document).ready(function ItemsList(Id) {
//    $.ajax({
//        type: "GET",
//        url: `../Item/SelectItem?id=${Id}`,
//        processData: false,
//        contentType: false,
//        success: function (result) {

//            $('#item').html(result);

//        },
//        error: function (result) {
//            alert(error.result);
//        }
//    });
//});


//$(".country").change(function () {
//    let id = $(".country option:selected").val();
//    $.ajax({
//        url: `/Item/SelectItem?id=${Id}`,
//        type: "GET",
//        data: { items: id },
//        success: function (data) {
//            let items = '';
//            $.each(data, function (i, city) {
//                items += '<option value="' + city.value + '">' + city.text + "</option>";
//            });
//            $(".city").html(items);
//        }
//    })
//})


//$(".save").click(function () {
//    let user = $(".user").val();
//    let cityId = $(".city option:selected").val();
//    let cityname = $(".city option:selected").text();
//    let countryname = $(".country option:selected").text();
//    $.ajax({
//        url: "/Ajax/AddUser",
//        type: "POST",
//        data: { username: user, cid: cityId },
//        success: function (data) {
//            let tr = "<tr><td>" + user + "</td> <td>" + cityname + "</td> <td>" + countryname + "</td></tr>";
//            $("tbody").append(tr);
//        }
//    })
//})


//window.addEventListener('load', function () {
//    getAllJobs();
//});

//function getAllJobs() {
//    sendGetRequest(`/JobQueue/List`, (e) => {
//        document.querySelector('#JobQueueContainer').innerHTML = e;
//        $('#thebasic-datatable').DataTable({ "pageLength": 50, "order": [[0, 'dasc']] });
//    });
//    //id: JobQueueContainer
//}

//function filterBy(event, filterType) {
//    const dropDown = document.querySelector('#filterDropDown');
//    dropDown.innerText = event.target.innerText;
//    switch (filterType) {
//        case '1':
//            // jobtype
//            sendGetRequest(`/JobQueue/GetJobTypes`, function (e) {
//                const container = document.querySelector('#filterContainer');
//                container.style.display = 'block';
//                container.innerHTML = e;
//                $('.select2').each(function () {
//                    var $this = $(this);
//                    $this.wrap('<div class="position-relative"></div>');
//                    $this.select2({
//                        // the following code is used to disable x-scrollbar when click in select input and
//                        // take 100% width in responsive also
//                        dropdownAutoWidth: true,
//                        width: '100%',
//                        dropdownParent: $this.parent()
//                    });
//                });
//            });
//            break;
//        case '2':
//            // status
//            break;
//    }
//}

//function filterJobsByJobType(jobType) {
//    sendGetRequest(`/JobQueue/FilterByJobType?jobType=${jobType}`, function (e) {
//        document.querySelector('#JobQueueContainer').innerHTML = e;
//        $('#thebasic-datatable').DataTable({ "pageLength": 50 });
//    });
//}


