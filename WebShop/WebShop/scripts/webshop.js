$(document).ready(function(){
    $("#HerrChk").click(function () {
        if ($("#HerrChk").is(":checked"))
        {
            $(".Herr").parent().parent().show();
        }
        else {
            $(".Herr").parent().parent().hide()
        }
       
    });

    $("#DamChk").click(function () {
        if ($("#DamChk").is(":checked"))
        {
            $(".Dam").parent().parent().show();
        }
        else {
            $(".Dam").parent().parent().hide();
        }
    });
});  