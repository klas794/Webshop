$(document).ready(function(){
    $("#HerrChk").click(function () {
        if ($("#HerrChk").is(":checked"))
        {
            $(".Herr").parent().show();
        }
        else {
            $(".Herr").parent().hide()
        }
       
    });

    $("#DamChk").click(function () {
        if ($("#DamChk").is(":checked"))
        {
            $(".Dam").parent().show();
        }
        else {
            $(".Dam").parent().hide();
        }
    });
});  