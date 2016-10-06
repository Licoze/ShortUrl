
var pop;
var validatiorOptions = {
    rules: {
        url_text: {
            required: true,
            url: true
        }
    },
    errorPlacement: function (error, element) {
        SetPopText( error.text());
        return true;
    }

}
function SetPopText(text) {
    $('#url_text').attr('data-content',text);
}
$(document).ready(function () {
     pop = $('#url_text').popover({
        animation: true,
        html: true,
        trigger: 'manual',
        content: "",
        placement: 'auto left'


    });


    pop.popover(effect);
});

function Validation() {
    var form = $("#inputblock");
    var input = $("#url_text");
    var isUrlValid = $("#mainform").validate(validatiorOptions).element("#url_text");
   if (!isUrlValid) {
        form.addClass("has-error");
        form.removeClass("has-success");
        pop.popover('show');
    } else {
        form.addClass("has-success");
        form.removeClass("has-error");
        pop.popover('hide');
        new AjaxUpdate(input.val());
    }
}
function AjaxUpdate(text) {

    ShortUrl.Services.Processing.AddNew(text, OnComplete, OnError);

    function OnError(error) {
        alert(error.get_message);
    }
    function OnComplete(result) {
        if (result.Success == false) {
            SetPopText(result.Data);
            pop.popover('show');
        }
        else {
            pop.popover('hide');
            ExecuteModal(result.Data);
        }

    }

}
function ExecuteModal(content) {
    $("#data").html(content);
    $("#myModal").modal('show');
}
