# Exception handling (try/catch/finally, throw, custom exceptions)
## Introduction
* https://www.google.com/url?q=https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/exception-handling&sa=D&ust=1603305226329000&usg=AOvVaw1Lml-EtjHdFXXiAvwsKd6s
* C#'s exception handling features help you to deal with exceptions, which are unexpected or **exceptional** situations that occur during **runtime**, as opposed to errors, which happen at compile time.
* Exception handling uses the try, catch, and finally keywords to try actions that might not succeed.
## Exceptions vs Errors
* Runtime errors can occur for a variety of reasons. Not all errors should be handled as exceptions in your code.
* Three kinds of run-time errors:
    * Usage Errors
        * An error in program logic that should be addressed not through exception handling but by modifying the faulty code.
        * These occur due to faulty program logic and should be addressed through code correction, not by handling exceptions when thrown.
    * Program Errors: A run time error that cannot necessarily be avoided by writing bug-free code.
        * May reflect a routine error condition. Avoid using exception handling to deal with program errors. Instead, prevent the exception by trying the action first. (DateTime.TryParseExact() vs DateTime.ParseExact)
    * System Failures: A runtime error that cannot be handled programmatically in a meaningful way.
        * Should not be handled using exception handling.
        * Any method can throw an OutOfMemoryException if the CLR can't allocate more memory.
        * You may be able to use an event to respond to these event, such as the AppDomain.UnhandledException and call the Environment.FailFast() method to notify the user before the app terminates.
## Exception Class
* The Exception Class is the base for **all** other exception classes. When any error occurs, the system or the application throws an exception that contains information about the error. When the exception is thrown by a method far down the call stack, the CLR will unwind the stack, looking for a method with a catch block for that specific exception type and execute the first such catch block that it finds. If it finds no catch block in the call stack, it terminates the process and displays an unhandled exception message.
* All runtime exceptions inherit form the SystemException class. All exceptions inherit from the Exception class.
## Try/Catch/Finally block/statements
* The try/catch statement consists of a try block followed by one or more catch clauses, which specify handlers for different exceptions. The try block contains the guarded code that may cause the exception. The block is executed until an exception is thrown or it is completed successfully. Using multiple catch statements is a way to filter for the exceptions you want to handle.
* The usage of these statements are to:
    * obtain and use resources in a try block
    * deal with exceptional circumstances in a catch block
    * release the resources in the finally block, which always runs regardless of result.
## Throw
* The throw statement can be used in a catch block to re-throw the exception that is caught by the catch statement so that the next method up the stack receives it, too.
* You can catch one exception and throw a different exception. When you do this in a catch block, specify the exception that you caught as the inner exception in the catch block.
## User-defined Exceptions
* To create custom exceptions, you must:
    * create your own exception classes
    * Derive(inherit) from the exception class
    * End the class name with the word "Exception"
    * Implement the three common constructors:
        * public SampleConstructor(){}
        * public SampleConstructor(string message) : base(message) {}
        * public SampleConstructor(string message, Exception inner) : base(message, inner) {}