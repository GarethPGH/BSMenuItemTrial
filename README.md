# BSMenuItemTrial

Attempt to use Data Driven Model article from Code Magazine
This was my attempt to literally follow verbatim this article in Code Magazine to create a data driven menu. 
However when I got to creating the CSHTML page for the MVC application, I got an error that would not compile. 
Either my code would compile, but there were unreachable parts. 
Basically my instance of the BSMenuItemManager would be created, but not populated, 
because somehow my prototype was a separate instance and not a prototype, so the Load() event was targeting the wrong instance.
Or, if I changed how it initialized and data loaded, the foreach loop in the CSHTML page would not run because Menus was not recognized.

I tried to work around that problem using information gathered from Stack Overflow from similar issues, 
and create a helper class to help point the linker in the right direction, but that did not work. 

This was supposed to be a verbatim copy, and it didn't work, so either I really misunderstand MVC, or the sample project code was somehow wrong.
