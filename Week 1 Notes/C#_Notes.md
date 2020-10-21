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

## Exception handling (try/catch/finally, throw, custom exceptions)

## Collections (In-memory storage of data)
* Arrays (1D, 2D, jagged, multidimensional)
    * Fixed Size, memory contiguous, elements must have values
    * Rank of an array is the number of dimensions of an array.
    * Jagged arrays are arrays where the array has a set number of rows, but the rows can be of differing lengths, like a bar graph shape. It is NOT 2D. In 2D arrays, every row has the same number of columns.
* Non-Generics (all items are converted to object form when added to these collections i.e. Boxing)
    * Stack
    * Queue
    * ArrayList
    * HashTable (KeyValue)
* Generics (Avoid the need for boxing by using Arrays internally, which are reference types that store the contents directly, not objects that refer to the data indirectly)
    * 'Stack<T>': Linear Data Structure LiFo 
    * 'Queues<T>': Linear Data Structure FiFo
    * List<T>: Dynamic Array
    * 'Dictionary<T,T>': Key Value pairs, don't need to iterate to get the data you need
    * 'SortedList<T>': Array of Key Value pairs sorted by keys.
* Collections inherit from interfaces that determine functionality
    * IIterator (iteratability) -> IEnumerable (GetEnumerator func.) -> IEnumerable<T> -> ICollection (Add and Remove func.)
    * From ICollection we get IList<T> -> List<T>, Stack<T>, Queue<T>, IDictionary<TKey, TValue> -> Dictionary<TKey, TValue>

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