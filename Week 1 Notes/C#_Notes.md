# C# Notes
 General purpose, object oriented, strongly typed language made by Microsoft


## Semantic code (DRY, Comments-inline, Comments-XML, KISS)



# Day 5

## Design patterns - singleton & factory

* Singleton Design Pattern:
    * A Singleton is a class that may only have a single instance of itself created, and the instance commonly allows for simple access.
    * There are many ways for this to be implemented in C#, but to ensure Thread Safety, you could use a Fully Lazy instantiation (Lazy&lt;T&gt;)
    * The ability to not use heavy objects/operations if it isn't needed avoids wasting resources, and is useful if you want to postpone a specific heavy object until others are done. Lazy&lt;T&gt; are thread-safe by default and is best used for performance and memory reduction.
    * This helps to hide dependencies, are lazy-loaded, and can be extended, but they can't be easily unit tested.
    * Vs. Static Class
        * Can extend class and implement interfaces
        * Allows access to a single created instance, which can be used as a parameter to other methods and treated as an object
        * Can have a constructor and be initialized with a STATE (parameter)
        * Methods can be overridden
        * A static class is loaded automatically by the CLR when the program or namespace containing the class is loaded
* Factory: One Class generates multiple instances of another class


## Multithreading (Async/await, Task, Thread)





