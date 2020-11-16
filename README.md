# SeleniumAttack

## Dictonary Attack using C#, Selenium and python 

The challenge of this project was to create an dictionary attack for the login page of an website. For demonstration purposes I used DVWA. (can be found at: http://www.dvwa.co.uk/)

The base idea of the application is to use an crawler to get the xPaths of the username, password and submit button and to insert lists of usernames and passwords in the hope of one working. This comes as an alternative to common known tools like Hydra, John the Ripper, Burp Suite. 

It comes with a GUI in which the user can insert his own xPaths(the user needs to put all the xPaths in place or the crawler will automate the task). There is a background button (creating 10-20 chrome tabs could be CPU intensive)
 ![image](https://user-images.githubusercontent.com/63077197/99292466-ebe04800-2849-11eb-83a3-2814269dcf7b.png)

This is how the program looks when is loading
![image](https://user-images.githubusercontent.com/63077197/99292504-f69add00-2849-11eb-95f9-46c4fe726d16.png)

And how the results are displayed
![image](https://user-images.githubusercontent.com/63077197/99292529-00244500-284a-11eb-8772-12bdcd9bce94.png)
