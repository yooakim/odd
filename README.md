# Octopus Deploy Demo (ODD)

This solution contains projects to demonstrate how Octopus Deploy works. At the moment the only project is:

* [ODD.Web]

## ODD.Web

![ODD.Web](https://github.com/yooakim/odd/blob/master/images/Capture.PNG)

Is a .NET Framework 4.x web application. It is a simple startpage with a method that will generate high CPU load. The intention is to be able to show the deployment pipeline 
and to test auto-scaling scenarios. 

The button "DoWork" will load the CPUs for 20 seconds to about 80% load. This can be useful if you want to test auto-scaling.  The DoWork method can be called via this URL.

[/Home/DoWorkAsync?duration=20] 

The durastion parameter is the number of seconds to generate the load for.


## Graphic profile

| Name | HEX | Comment |
| ---- | ---- | ---- |
| Primary color / Basefarm Blue | #08314c | |
| Secondary color / Basefarm Light Blue | #cad6dd | |

## Feedback

Please submit any feedback as [issues](https://github.com/yooakim/odd/issues/new) 


