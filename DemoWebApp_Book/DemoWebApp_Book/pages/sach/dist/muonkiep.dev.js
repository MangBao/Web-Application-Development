"use strict";

window.onload = function () {
  function login() {
    var btnlgin = document.querySelector('.btnlgin');

    btnlgin.onclick = function () {
      var txtlg = document.querySelector('.txtlg');
      var txtpw = document.querySelector('.txtpw');

      if (txtlg.value == "khachhang@gmail.com" && txtpw.value == "123") {
        var changelgin = document.querySelector('.blocklgin');
        changelgin.innerHTML = 'Khách hàng A';
        var changeout = document.querySelector('.blocksgup');
        changeout.innerHTML = 'Đăng xuất';
        txtlg.value = "";
        txtpw.value = "";
      }

      if (txtlg.value == "quantri@gmail.com" && txtpw.value == "123") {
        window.open("../quantri/quantri.html");
      }

      if (txtlg.value == "nhanvien@gmail.com" && txtpw.value == "123") {
        window.open("../nhanvien/nhanvien.html");
      }
    };
  }

  login();

  function openbag() {
    var openbag = document.querySelector('.bag i');

    openbag.onclick = function () {
      window.open('../bag/bag.html');
    };
  }

  openbag();
};