﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var principal = new Principal();

//Codigo de Usuarios
var user = new User();
var imageUser = (evt) => {
    user.archivo(evt, "ImageUser");
}

$().ready(() => {
    let URLactual = window.location.pathname;
    principal.userLink(URLactual);
});