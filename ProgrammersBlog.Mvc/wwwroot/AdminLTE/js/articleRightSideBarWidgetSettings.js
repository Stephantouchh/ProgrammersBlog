﻿$(document).ready(function () {

    // Select2
    $('#categoryList').select2({
        theme: 'bootstrap4',
        placeholder: "Lütfen bir kategori seçiniz...",
        allowClear: true
    });

    $('#filterByList').select2({
        theme: 'bootstrap4',
        placeholder: "Lütfen bir filtre türü seçiniz...",
        allowClear: true
    });

    $('#orderByList').select2({
        theme: 'bootstrap4',
        placeholder: "Lütfen bir sıralama türü seçiniz...",
        allowClear: true
    });

    $('#isAscendingList').select2({
        theme: 'bootstrap4',
        placeholder: "Lütfen bir sıralama tipi seçiniz...",
        allowClear: true
    });

    // Select2


    // jQuery UI - DatePicker

    $(function () {
        $("#startAtDatePicker").datepicker({
            closeText: "kapat",
            prevText: "&#x3C;geri",
            nextText: "ileri&#x3e",
            currentText: "bugün",
            monthNames: ["Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran",
                "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"],
            monthNamesShort: ["Oca", "Şub", "Mar", "Nis", "May", "Haz",
                "Tem", "Ağu", "Eyl", "Eki", "Kas", "Ara"],
            dayNames: ["Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi"],
            dayNamesShort: ["Pz", "Pt", "Sa", "Ça", "Pe", "Cu", "Ct"],
            dayNamesMin: ["Pz", "Pt", "Sa", "Ça", "Pe", "Cu", "Ct"],
            weekHeader: "Hf",
            dateFormat: "dd.mm.yy",
            firstDay: 1,
            isRTL: false,
            showMonthAfterYear: false,
            yearSuffix: "",
            duration: 1000,
            showAnim: "fold",
            showOptions: { direction: "left" },
            /*  minDate: -3,*/
            maxDate: 0,
            onSelect: function (selectedDate) {
                $("#endAtDatePicker").datepicker('option', 'minDate', selectedDate || getTodaysDate());
            }
        });

        $("#endAtDatePicker").datepicker({
            closeText: "kapat",
            prevText: "&#x3C;geri",
            nextText: "ileri&#x3e",
            currentText: "bugün",
            monthNames: ["Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran",
                "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"],
            monthNamesShort: ["Oca", "Şub", "Mar", "Nis", "May", "Haz",
                "Tem", "Ağu", "Eyl", "Eki", "Kas", "Ara"],
            dayNames: ["Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi"],
            dayNamesShort: ["Pz", "Pt", "Sa", "Ça", "Pe", "Cu", "Ct"],
            dayNamesMin: ["Pz", "Pt", "Sa", "Ça", "Pe", "Cu", "Ct"],
            weekHeader: "Hf",
            dateFormat: "dd.mm.yy",
            firstDay: 1,
            isRTL: false,
            showMonthAfterYear: false,
            yearSuffix: "",
            duration: 1000,
            showAnim: "fold",
            showOptions: { direction: "left" },
            /*  minDate: -3,*/
            maxDate: 0
        });
    });

    // jQuery UI - DatePicker

});