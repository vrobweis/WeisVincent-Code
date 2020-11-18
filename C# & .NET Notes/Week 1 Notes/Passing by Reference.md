# Passing by Reference
* By default, C# is pass by value, but you can also pass by reference!
## Out keyword ?
* Used for the passing of arguments to methods as a reference type
* Generally used when a method returns multiple values
* The out parameter does not pass the property
* The variable need not be initialized when passing an out parameter

## Ref keyword
* used for the passing of arguments by a reference
* Or we can say that if any changes made in this argument in the method will reflect in that variable when the control return to the calling method.
* The ref parameter does not pass the property
* The variable needs to be initialized before passing