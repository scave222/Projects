// // const img = document.getElementById('img');

// function changeImage(imgElement, imgPath){
//     imgElement.src = imgPath;
// }

// // function styleControl(formElement){
// //     formElement.style.backgroundColor = "#eee";
// // }

// // function hideStyle(formElement){
// //     formElement.style.backgroundColor = "#fff";
// // }

// function styleControl(formElement,bg){
//     formElement.src = bg;
// }



// $(document).ready(function(){
//     $("#menu").click(function(){
//         $("#navPanel").fadein('slow');
//     });

//     $("#navPanel").click(function(){
//         $(this).fadeOut('slow');
//     })
// })

$(document).ready(function() {
    // alert('Hello')
    $('#menu').click(function() {
        $('#navPanel').fadeIn('slow');
    });
    $('#navPanel').click(function() {
        $(this).fadeOut("slow");
    });
});