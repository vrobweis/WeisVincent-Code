# C# Notes

# Day 2

## Access Modifiers

## Data Types

## Extended Modifiers

## Class, struct, interface, enum

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

## Exception handling (try/catch/finally, throw, custom exceptions)

## Collections

# Day 3

## Test-driven Development [TDD] (code coverage, unit tests, mocking)

## Application monitoring (breakpoints, debugging, logging, tracing)

## OOP Pillars
* Abstraction
* Polymorphism
* Inheritance
* Encapsulation

## Serialization (FileIO, Regular expressions, Serializer-JSON/text/XML)

# Day 4

## Design patterns - singleton & factory

## Delegates (Action, Event, Function, lambda, LINQ, Predicate)

## Multithreading (Async/await, Task, Thread)

## Variance (As, Boxing, Casting, Contravariant, Covariant, Invariant, Is, Out, Ref, Typeof)