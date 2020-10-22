# Delegates (Action, Event, Function, lambda, LINQ, Predicate)
A Delegate is a type that represents a reference to a method with a defined parameter and return type. You can associate a delegate instance with any method with a compatible signature and return type, and then call the method through the delegate instance.
* Summarized as type-safe function pointers in C#
* Allows for: 
    * method chaining, which create a pipeline and lifecycle of a framework
    * anonymous Methods which are the foundation of Lambda ep.
    * Events
    * Loose coupling
* Type of Delegates
    * Single-cast
    * Multi-cast
    * Strongly-Typed Delegates
* Premade delegates:
    * Action
    * ?
* A delegate's ability to refer to methods as a parameter makes them ideal for defining callback methods.
* Any accessible method or struct that matches the delegate type and return type can be assigned to the delegate. Delegates are object oriented, type safe, and secure.





## Binding
Binding is the process that establishes a connection between an app UI and the data it displays. When the data changes its value, the elements (in memory) bound to that data reflect changes automatically.
* Early Binding (AKA Static Binding, Static Dispatch, or Compile-Time Binding)
    * The compiler (or linker) directly associates a stack memory address to the function call, and replaces the call with a machine language instruction that tells the mainframe to leap to the address of the function.
* Late Binding (AKA Dynamic Binding, Dynamic Dispatch, Dynamic Linkage, or Run-time Binding)
    * This is when an algorithm is created that uses a **caller-supplied** method that implements part of the algorithm (function pointers in C++). In .NET, late binding refers to overriding a virtual method. The compiler builds virtual tables for every virtual or interface method call which is used at run-time to determine the implementation to execute.
    * **In .NET, Delegates use late binding.**
