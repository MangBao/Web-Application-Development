"use strict";

window.onload = function () {
  function logout() {
    var logout = document.querySelector('.logout');

    logout.onclick = function () {
      window.open('../../trangchu.html');
    };
  }

  logout();
};