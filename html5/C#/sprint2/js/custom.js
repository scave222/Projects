$(document).ready(function(){
    $('#one').text('web page is ready').css('color','red');
    $('h2').css('background-color','green');
    $('#click').click(function(){
        $('#one').css('background-color','green'); 
    })
    $('#unclick').click(function(){
        $('#one').css('background-color', 'white');
    })

    function forcast(){
    fetch(' https://api.openweathermap.org/data/2.5/weather?q=lagos&appid={587a5333305cdede52312cfc42509168}&lang=en&units=metric')
    .then(function(response){
        return (response.json());
    })
    .then(function(data){
        Console.log(data);})

    }
    forcast();
}) 

//http://samples.openweathermap.org/data/2.5/weather?q=lagos&appid=587a5333305cdede52312cfc42509168