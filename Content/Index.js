var Index = {
    gravar: function(){
        $.ajax({
            type: "POST",
            url: "bot/Gravar",
            success: function (data) {
                console.log(data);

            },
            error: function (error) {
                console.log(error);
            }
        });
    }
}