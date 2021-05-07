$(document).ready(function () {
    var modal = document.getElementById('myModal');
    var sign_up = document.getElementById('sign-up');
    var sign_in = document.getElementById('sign-in');
    var s_up = document.getElementById('s-up');
    var s_in = document.getElementById('s-in');
    var userAcc = document.getElementById('userAcc');
    var signIn_mb = document.getElementById('sign-in-mb');
    var sw_logup = document.getElementsByClassName('auth__form-switch-btn')[0];
    var sw_login = document.getElementsByClassName('auth__form-switch-btn')[1];


    var user = [];

    s_in.onclick = (e) => {
        e.preventDefault();
        var a = $('#a').val();
        var b = $('#b').val();

        user[0] = {
            username: 'admin',
            password: '1234'
        }
        for (var i = 0; i <= user.length; i++) {
            if ((a == user[0].username) && (b == user[0].password)) {
                // $('#ad').css('display', 'block');
                $('li').removeClass('class_none');
                $('.user-link').removeClass('class_none')
                sign_up.style.display = 'none';
                sign_in.style.display = 'none';
                modal.style.display = 'none';
                $(signIn_mb).css('display', 'none');
            }
        }
    };
    s_up.onclick = (e) => {
        var a = $('#')
    }

    // function Login() {
    //     for (var i = 0; i <= user.length; i++) {
    //         if ((a == 'admin' /*user[0].username*/ ) && (b == '123456' /*user[0].password*/ )) {
    //             $('#ad').css('display', 'block');
    //             $('li').removeClass('class_none');
    //             sign_up.style.display = 'none';
    //             sign_in.style.display = 'none';
    //             modal.style.display = 'none';
    //         }
    //     }
    // }
    // cb_home2.onclick = (e) => {
    //     e.preventDefault();
    //     $('#myModal').removeClass('class_block');
    //     $('#myModal').addClass('class_none');
    // };
    // cb_home1.onclick = (e) => {
    //     e.preventDefault();
    //     $('#myModal').removeClass('class_block');
    //     $('#myModal').addClass('class_none');
    // };

    sign_up.onclick = (e) => {
        e.preventDefault();
        // modal.style.display = 'block';
        $('#myModal').css('display', 'block');
        $('#s_in').css('display', 'none');
        $('#s_up').css('display', 'block');
    };
    sign_in.onclick = (e) => {
        e.preventDefault();
        $('#myModal').css('display', 'block');
        $('#s_up').css('display', 'none');
        $('#s_in').css('display', 'block');
    };

    signIn_mb.onclick = (e) => {
        e.preventDefault();
        modal.style.display = 'block';
        $('#myModal').css('display', 'block');
        $('#s_up').css('display', 'none');
        $('#s_in').css('display', 'block');
    };



    sw_logup.onclick = (e) => {
        e.preventDefault();
        $('#s_in').css('display', 'block');
        $('#s_up').css('display', 'none');
    };

    sw_login.onclick = (e) => {
        e.preventDefault();
        $('#s_in').css('display', 'none');
        $('#s_up').css('display', 'block');
    };




    // window.addEventListener("click", function(e) {
    //     if (e.target == modal) {
    //         // document.getElementsByClassName('modal').style.removeProperty = "display";
    //         // $(modalcls).attr("style", "display: none;");
    //         $('#myModal').removeClass('class_block');
    //         $('#myModal').addClass('class_none');
    //     } else if (e.target == modalcls) {
    //         $('#myModal').removeClass('class_block');
    //         $('#myModal').addClass('class_none');
    //     } else if (e.target == document.getElementsByClassName('modal__overlay')) {
    //         $('#myModal').removeClass('class_block');
    //         $('#myModal').addClass('class_none');
    //     }
    // });
    var menu = new MmenuLight(
        document.querySelector('#menu'),
        'all'
    );

    var navigator = menu.navigation({
        selectedClass: 'Selected',
        slidingSubmenus: true,
        theme: 'dark',
        title: 'Menu'
    });

    var drawer = menu.offcanvas({
        position: 'left'
    });

    //	Open the menu.
    document.querySelector('a[href="#menu"]')
        .addEventListener('click', evnt => {
            evnt.preventDefault();
            drawer.open();
        });
    /*function changenumber() {
        var cong = document.querySelector('.btncong');
        var tru = document.querySelector('.btntru');
        var text = document.querySelector('.btntext')
        cong.onclick = function () {
            text.value = parseInt(text.value) + 1;
        }
        tru.onclick = function () {
            if (parseInt(text.value) <= 0) {
                text.value == 0;
            }
            else {
                text.value = parseInt(text.value) - 1;
            }
        }
    }
    changenumber()*/
    
    
})
function huysach() {
    var huy = document.querySelector('.btnhuysach')
    console.log(huy);
    huy.onclick = function () {
        var item = document.querySelector('.item')
        item.outerHTML = ""
    }
}
huysach();
$(".btntru").click(function () {
    var input_el = $(this).next('input');
    var v = input_el.val() - 1;
    if (v >= input_el.attr('min'))
        input_el.val(v)
});


$(".btncong").click(function () {
    var input_el = $(this).prev('input');
    var v = input_el.val() * 1 + 1;
    if (v <= input_el.attr('max'))
        input_el.val(v)
});