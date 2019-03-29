$(function() {
    // if the Geolocation feature is supported, get the user's location
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showWeatherData, showError);
    } else {
        $("#map").append("<p>Error: Geolocation is not supported by this browser.</p>");
    }
})

function showWeatherData(position) {
    // display the coordinates
    $("#lat").append(position.coords.latitude);
    $("#long").append(position.coords.longitude);
    // create the link for the Google API call
    var img_url = "http://maps.googleapis.com/maps/api/staticmap?center=" + position.coords.latitude +
                  "," + position.coords.longitude + "&zoom=14&size=600x485&sensor=false";
    // load the image from the Google API call
    $("#map .panel-body").append("<img class='img-responsive' src='" + img_url + "'>");
    // perform AJAX request to get the current weather data using the browser's coordinates,
    // imperial units, my own app id, and a specified callback function
    $.ajax({
        type: 'GET',
        url: 'http://api.openweathermap.org/data/2.5/weather?lat='+position.coords.latitude+
             '&lon='+position.coords.longitude+'&units=imperial&appid=467a50a63b6d907fb614520f891a7605',
        dataType: 'jsonp',
        jsonp: 'callback',
        jsonpCallback: 'loadCurrentWeather',
        crossDomain: true,
        success: function(data) {
           console.log("Weather API call successful!");
        },
        error: function(error) {
           console.log("Weather API call failed! Error: " + error.message);
        }
    });
    // perform another AJAX request to get the forecast data using the browser's coordinates,
    // imperial units, my own app id, and a specified callback function
    $.ajax({
        type: 'GET',
        url: 'http://api.openweathermap.org/data/2.5/forecast?lat='+position.coords.latitude+
             '&lon='+position.coords.longitude+'&units=imperial&appid=467a50a63b6d907fb614520f891a7605',
        dataType: 'jsonp',
        jsonp: 'callback',
        jsonpCallback: 'loadForecast',
        crossDomain: true,
        success: function(data) {
           console.log("Forecast API call successful!");
        },
        error: function(error) {
           console.log("Forecast API call failed! Error: " + error.message);
        }
    });
}

// this function was given in the template for geolocation on w3schools
// it displays the appropriate error message based on which error occurred
function showError(error) {
    switch(error.code) {
        case error.PERMISSION_DENIED:
            $("#map").append("<p>Error: User denied permission.</p>");
            break;
        case error.POSITION_UNAVAILABLE:
            $("#map").append("<p>Error: User's position is unavailable.</p>");
            break;
        case error.TIMEOUT:
            $("#map").append("<p>Error: The request timed out.</p>");
            break;
        case error.UNKNOWN_ERROR:
            $("#map").append("<p>Error: Unknown.</p>");
            break;
    }
}

function loadCurrentWeather(data) {
    // put the essential weather information on the left side of the panel
    $("#current_weather .panel-body .left").append(
        "<h4>"+data.name+"</h4>"+
        "<h4>"+data.main.temp+" &#8457;</h4>"+
        "<img class='center-block' src=http://openweathermap.org/img/w/"+data.weather[0].icon+".png>"+
        "<p class='text-capitalize'>"+data.weather[0].description+"</p>"
    );
    // put extra information on the right side
    $("#current_weather .panel-body .right").append(
        "<p><b>Wind:</b> "+data.wind.speed+"mps</p>"+
        "<p><b>Humidity:</b> "+data.main.humidity+"%</p>"+
        "<p><b>Minimum Temperature:</b> "+data.main.temp_min+" &#8457;</p>"+
        "<p><b>Maximum Temperature:</b> "+data.main.temp_max+" &#8457;</p>"+
        "<p><b>Pressure:</b> "+data.main.pressure+" hPa</p>"
    );
}

function loadForecast(data) {
    // keep track of which hour/day forecast is being displayed
    var count = 0;
    // display the first four
    while (count < 4) {
        // add panels for each one inside the forecast panel
        $("#forecast .row").append(
            "<div class='col-md-3'>"+
                "<div class='panel panel-default text-center'>"+
                    "<div class='panel-heading'>"+
                        "<h3 class='panel-title'>"+getTime(data.list[count].dt)+"</h3>"+
                    "</div>"+
                    "<div class='panel-body'>"+
                        "<h4>"+data.list[count].main.temp+" &#8457;</h4>"+
                        "<img class='center-block' src=http://openweathermap.org/img/w/"+data.list[count].weather[0].icon+".png>"+
                        "<p class='text-capitalize'>"+data.list[count].weather[0].description+"</p>"+
                    "</div>"+
                "</div>"+
            "</div>"
        );
        // increment the counter
        count++;
    }

    // scroll through the forecast every 3 seconds            
    var timer = setInterval(function(){
        // animate the removal by fading out the first column
        $("#forecast .col-md-3:first").fadeOut();
        // wait 1 second for the animations to complete, then remove the last forecast
        setTimeout(function(){
            $("#forecast .col-md-3:first").remove();
            // add a new forecast to the right
            $("#forecast .row").append(
                "<div class='col-md-3'>"+
                    "<div class='panel panel-default text-center'>"+
                        "<div class='panel-heading'>"+
                            "<h3 class='panel-title'>"+getTime(data.list[count].dt)+"</h3>"+
                        "</div>"+
                        "<div class='panel-body'>"+
                            "<h4>"+data.list[count].main.temp+" &#8457;</h4>"+
                            "<img class='center-block' src=http://openweathermap.org/img/w/"+data.list[count].weather[0].icon+".png>"+
                            "<p class='text-capitalize'>"+data.list[count].weather[0].description+"</p>"+
                        "</div>"+
                    "</div>"+
                "</div>"
            );
            // increment the counter
            count++;
            // hide them by changing display to none
            $("#forecast .col-md-3:last").css("display","none");
            // animate them by using the fadeIn function
            $("#forecast .col-md-3:last").fadeIn();
            // stop the function from running when it has reached the last forecast
            if(count == data.list.length-1)
                clearTimeout(timer);
        }, 500);               
    }, 3000);
}

// this function creates a Date object for the specified unixTimeString to properly format the date and time
// information that will be displayed in the forecast panels
function getTime(unixTimeString) {
    var date = new Date(unixTimeString*1000); // multiply by 1000 to get milliseconds
    var hour = date.getHours();
    var hourString;
    if (hour == 0)
        hourString = "12 AM";
    else if (hour < 12)
        hourString = hour + " AM";
    else if (hour == 12)
        hourString = "12 PM";
    else
        hourString = (hour-12) + " PM";

    return hourString+"</br><small>"+date.toLocaleDateString()+"</small>";   
}