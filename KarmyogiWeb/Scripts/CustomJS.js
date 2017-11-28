(function ($) {
    $('.spinner .btn:first-of-type').on('click', function () {
        var obj = $(this).closest('.spinner').children('input[type = text]')
        $(obj).val(parseInt($(obj).val(), 10) + 1);
    });
    $('.spinner .btn:last-of-type').on('click', function () {
        var obj = $(this).closest('.spinner').children('input[type = text]')
        $(obj).val(parseInt($(obj).val(), 10) - 1);
    });

    $('#ReligionId').change(function () {
        var ReligionId = $(this).val();
        $.getJSON("/Home/GetCasteByReligionId", { id: ReligionId },
            function (religionData) {
                var select = $("#CasteId");
                select.empty();
                select.append($('<option/>', {
                    value: "0",
                    text: "* Select Caste"
                }));
                $.each(religionData, function (index, itemData) {
                    select.append($('<option/>', {
                        value: itemData.Value,
                        text: itemData.Text
                    }));
                });
            });
    });
})(jQuery);