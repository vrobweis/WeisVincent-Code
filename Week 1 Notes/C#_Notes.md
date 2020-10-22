# C# Notes

# Day 2

## Access Modifiers
* change the behavior and scope of types
* Scopes
    * private (default for member types, accessible only by containing class)
    * protected (accessible by the same class and child classes)
    * internal (accessible by the same assembly but not by others)
    * public
* Properties
    * Getters and setters (Microsoft calls them smartfields)

## Memory Allocation
* Stack memory
    * Faster
    * Stacked and easily accessed
* Heap memory
    * Clusterf pile of data that isn't as easily accessed
* Value types store directly in the stack, reference types store an address in the stack, and the value in the heap

## Data Types
* All types in C# are inherited directly or indirectly from System.Object
* Value Types
    * Structs 
    * Enums
    * predefined types (int, long, short, byte, DateTime, char)
* Reference Types
    * Classes
    * Interface
    * Delegates
    * predefined reference types (string, arrays, collections etc.)
* Boxing is converting a value type to a reference type, unboxing is the reverse.

## Extended Modifiers

## Semantic code (DRY, Comments-inline, Comments-XML, KISS)

## Common Language Runtime (BCL, CIL, CLI, CLR, CTS, JIT, VES)
* The CLR is the .NET Framework's implementation of a Virtual Execution System (VES). It defines
    * a hypothetical machine with an associated machine model and state
    * a set of control flow constructs
    * an exception handling model
* https://en.wikipedia.org/wiki/Common_Language_Infrastructure
    * C#, F#, VB can all be used with the .CLI Microsoft made for .NET
    * Each language still uses their own compiler but compile into the Common Intermediate Language, formerly called Microsoft Intermediate Language (CIL/MSIL), and then that code is passed to the runtime (Common Language Runtime)
* When you compile, you can either make a library (.dll) or an executable assembly (.exe)
* The Common Type System (CTS) is used by the CLR to enforce strict typing and code verification, even between the disparate .NET languages.
    * The CTS is the middle man between various languages. (i.e. CTS uses System.Int32, C# uses int, VB uses integer. CTS uses System.Int16, C# uses short, VB uses foo.)
    * Common Type System used to ensure a common mapping or standardization for types in each language
* Common Language Specification ensures that each .NET compliant language follows certain rules (such as OOP or the starting index number for arrays and the like)

## Runtime Environment (garbage collection, managed, unmanaged)
* garbage collection is when the virtual execution system frees the memory not in use.






## Test-driven Development [TDD] (code coverage, unit tests, mocking)





# Day 4

## Serialization (FileIO, Regular expressions, Serializer-JSON/text/XML)



# Day 5

## Design patterns - singleton & factory

## Delegates (Action, Event, Function, lambda, LINQ, Predicate)

## Multithreading (Async/await, Task, Thread)

## Variance (As, Boxing, Casting, Contravariant, Covariant, Invariant, Is, Out, Ref, Typeof)