IndainRetailSupler.Modules.Category = function () {
    'use strict';
    var init = function () {

        $('.dropdown-menu a').click(function () {
            $('#search_concept').text($(this).text());
        });
        // bindEvents();
        // initializeGrid(recordsGridSelector);
        // checkIfLoadedRecordIsInvalid();
    };

    return {
        init: init
        //initPrintMode: initPrintMode
    };
};