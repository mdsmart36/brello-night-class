$(document).ready(function (){
    $('#list-submit').on('click', function (e) {
        e.preventDefault();

        $.post("/Boards/CreateList",{})
    });
});