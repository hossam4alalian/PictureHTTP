// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    $('#getAllPictures').click(function () {
        $.ajax({
            url: '/Home/GetAllPictures',
            success: function (data) { $("#allPictures").html("Your pictures: " + data) },
            error: function () { console.log('error'); }
        });
    });

    $('#upload').click(function () {
        $.ajax({
            url: '/Home/UploadPicture',
            data: {
                pic: "new.png"
            },
            success: function (data) { $("#allPictures").html("Your pictures: " + data) },
            error: function () { console.log('error'); }
        });
    });
});
