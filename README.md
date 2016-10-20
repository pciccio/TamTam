# TamTam
TamTam Back-end Test

Environment:

Windows Pro,
IIS 10,
VS 2015 RC3,
.Net Framework 4.6.1,

Front-end:
http://tamtamweb.azurewebsites.net/Main.html

Back-end API endpoint:

GET

http://tamtamapi.azurewebsites.net/movies/getbytitle/REPLACE_BY_MOVIE_TITLE
http://tamtamapi.azurewebsites.net/movies/getbytitleandyear/REPLACE_BY_MOVIE_TITLE/REPLACE_BY_YEAR

Application Front was configured to use production API.
=> http://tamtamapi.azurewebsites.net/movies/

Just configure 

TamTam.Services (API)

TamTam.UI.Web.TestSite (Front-end)

For run on IIS or IIS Express to run application locally (The first execution of server It's a bit slower (~5 seconds)).

