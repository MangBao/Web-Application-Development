window.onload = function (){
    function login(){
        var btnlgin = document.querySelector('.btnlgin');
        btnlgin.onclick= function(){
            let txtlg = document.querySelector('.txtlg');
            let txtpw = document.querySelector('.txtpw');
            if(txtlg.value == "khachhang@gmail.com" && txtpw.value == "123"){
                let changelgin = document.querySelector('.blocklgin')
                changelgin.innerHTML = 'Khách hàng A'
                let changeout = document.querySelector('.blocksgup')
                changeout.innerHTML = 'Đăng xuất'
                txtlg.value = "" 
                txtpw.value = ""
            }
            if(txtlg.value == "quantri@gmail.com" && txtpw.value == "123"){
                window.open("../quantri/quantri.html")
            }
            if(txtlg.value == "nhanvien@gmail.com" && txtpw.value == "123"){
                window.open("../nhanvien/nhanvien.html")
            }
        }
    }
    login()
    function changenumber(){
        var cong = document.querySelector('.btncong')
        var tru = document.querySelector('.btntru')
        var text = document.querySelector('.btntext')
        cong.onclick = function(){
            text.value = parseInt(text.value) + 1;
        }
        tru.onclick = function(){   
            if(parseInt(text.value)<=0){
                text.value == 0;
            }
            else{
                text.value = parseInt(text.value) - 1;
            }
        }
    }
    changenumber()
    function huysach(){
        var huy = document.querySelector('.btnhuysach')
        console.log(huy);
        huy.onclick = function(){
            var item = document.querySelector('.item')
            item.outerHTML = ""
        }
    }
    huysach();
}