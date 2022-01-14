window.IndainRetailSupler = window.IndainRetailSupler || {};
window.IndainRetailSupler.Modules = window.IndainRetailSupler.Modules || {};


    $.ajax({
        url: '/Category/category',
        contentType: 'application/html; charset=utf-8',
        type: 'GET',
        dataType: 'html',

        success: function (response) {

            $('#CategoryDropdown').html(response);
        },
        error: function (error) {
            $(this).remove();

        }
    })


   
