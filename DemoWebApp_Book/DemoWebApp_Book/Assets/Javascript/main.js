window.onload = function () {
    function login() {
        var btnlgin = document.querySelector('.btnlgin');
        btnlgin.onclick = function () {
            let txtlg = document.querySelector('.txtlg');
            let txtpw = document.querySelector('.txtpw');
            if (txtlg.value == "khachhang@gmail.com" && txtpw.value == "123") {
                let changelgin = document.querySelector('.blocklgin')
                changelgin.innerHTML = 'Khách hàng A'
                let changeout = document.querySelector('.blocksgup')
                changeout.innerHTML = 'Đăng xuất'
                txtlg.value = ""
                txtpw.value = ""
            }
            if (txtlg.value == "quantri@gmail.com" && txtpw.value == "123") {
                window.open("pages/quantri/quantri.html")
            }
            if (txtlg.value == "nhanvien@gmail.com" && txtpw.value == "123") {
                window.open("pages/nhanvien/nhanvien.html")
            }
        }
    }
    login()
    function openbag() {
        var openbag = document.querySelector('.bag i')
        openbag.onclick = function () {
            window.open('./pages/bag/bag.html')
        }
    }
    openbag();
}