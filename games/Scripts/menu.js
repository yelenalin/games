// ---- menu -----

// $(function () {
//         if ($(window).width() > 600) {

//             $('.menu,.login').show();
//             $('.menu-calss').hide();
//             $('#menu-class,.menu-calss').hover(function () {
//                 $('.menu-calss').toggle();

//             });

//         };

//         if ($(window).width() < 580) {

//             $('.menu-calss').hide();
//             $('#menu-class').click(function () {
//                 $('.menu-calss').toggle();
//             });

//             $('.menu,.login').hide();
//             $('.burger-box').click(function () {
//                 $('.menu,.login').toggle();
//             });
//         };
// }); 

function adjustStyle(width) {
    width = parseInt(width);
    if (width > 1200) {
        $('.menu,.login').show();
        $('.menu-calss').hide();
        $('#menu-class,.menu-calss').hover(function () {
            $('.menu-calss').toggle();
        });
    } else if(width > 580){
        $('.menu,.login').show();
        $('.menu-calss').hide();
        $('#menu-class,.menu-calss').click(function () {
            $('.menu-calss').toggle();
        });
    }else{
        $('.menu-calss').hide();
        $('#menu-class').click(function () {
            $('.menu-calss').toggle();
        });

        $('.menu,.login').hide();
        $('.burger-box').click(function () {
            $('.menu,.login').toggle();
        });
    }
}

$(function () {
    adjustStyle($(this).width());
    $(window).resize(function () {
        adjustStyle($(this).width());
    });
});


 //----輪播----
 
$(function () {
    $(".Banner-demo .col-3").click(function () {
        var img = $(this).find("img").attr("src");
        $(".Banner").find("img").attr("src", img);
    });
});