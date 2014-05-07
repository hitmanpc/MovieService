MovieService
============

WCF Service that can be hosted in Console or Web. 

To Host WCF Library in console:
Option 1: run debug instance on MovieConsoleHost project
Option 2: build and run as ADMINISTRATOR the MovieService\MovieConsoleHost\bin\Debug\MovieConsoleHost.exe Assuming you are in the debug configuration

Directions for Running Console:
1. enter a host localhost:xxxx where xxxx is any port but optional as port 80 is default. You can use the WcfTestClient.exe explained below or browse in your favorite browser
2. enter api key given at registering at: http://www.themoviedb.org/ or given in outside communication.
3. enter your movie title then enter
4. list of all titles and original titles containing the words will return.


To Host WCF Library in Web:
Easiest option is to run in iis express: run debug instance on MovieConsoleHost project
1. after deployment. Navigate to "Movie Service Test" link in browser


WCF Test Client:
Just in case you would like to view functionality outside of the console or web app use the following:
find your visualstudio command prompt and use WcfTestClient.
Goto File --> Add Service or Crtl+shit+A
add the url displayed in console or web app above

