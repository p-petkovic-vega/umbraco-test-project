$(document).ready(function () {

    $('#form').on('submit', function (e) {
        if (!validateRequiredFields()) {
            e.preventDefault();
        }
    });

    $('#add-class').on('click', function () {
        $('#classRow').clone().appendTo($('#classTable tbody'));
    });
});

function validateRequiredFields() {
    if ($('#resort').prop('selectedIndex') == -1) {
        return false;
    }
    if (!$('#reference-number').val().length) {
        return false;
    }
    if (!$('#name').val().length) {
        return false;
    }
    if (!$('#telephone-number').val().length) {
        return false;
    }
    if (!$('#email-address').val().length) {
        return false;
    }
}