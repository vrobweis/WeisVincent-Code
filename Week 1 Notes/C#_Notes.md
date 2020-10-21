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



# Day 3

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
    * Stack&lt;T&gt;: Linear Data Structure LiFo 
    * Queues&lt;T&gt;: Linear Data Structure FiFo
    * List&lt;T&gt;: Dynamic Array
    * Dictionary&lt;T,T&gt;: Key Value pairs, don't need to iterate to get the data you need
    * SortedList&lt;T&gt;: Array of Key Value pairs sorted by keys.
* Collections inherit from interfaces that determine functionality
    * IIterator (iteratability) -> IEnumerable (GetEnumerator func.) -> IEnumerable&lt;T&gt; -> ICollection (Add and Remove func.)
    * From ICollection we get IList&lt;T&gt; -> List&lt;T&gt;, Stack&lt;T&gt;, Queue&lt;T&gt;, IDictionary&lt;TKey, TValue&gt; -> Dictionary&lt;TKey, TValue&gt;

## OOP Pillars (A PIE)

### Before the Pillars..
* Interfaces
    * Think contracts. Interfaces contain definitions fora group of related functionality, which a non-abstract class or struct must implement. A Dog might implement a living interface, for example.
    * These can't be instanced, meaning you can't make an object of this type and fill in fields or properties for an interface. It's a ruleset, not an object. Think like a set of standards for sports in general, not a specific sport.
    * No constructors, all method stubs declared within interfaces are implicitly abstract, may define static methods, which then must have at least one implementation.
    * From C# Version 8.0 onward, an interface may define a default implementation for members, which allows you to more easily edit an interface or add functionality later on without changing every single class that implements it.
* Abstract Classes
    * Classes denoted using the abstract keyword. These CAN have constructors to initialize fields.
    * Often they contain unimplemented method stubs, to denote required functionality without forcing a means of doing so. They initiate a structure. 
    * May have abstract and non abstract methods
    * May have fields
    * A dog might inherit from an abstract animal class, for example. There won't be any need for a generic animal without more specifics, but making an abstract animal class allows you to make easily reusable code that applies to any child class.

### The Pillars of OOP
* Abstraction
    * A technique for dealing with complexity by simplifying how the users interface with your work
    * It splits the functionality needed by the user with the implementation you put forth.
    * Hiding the implementation of how data is processed, how logic is executed, and show your end user only the properties/methods they need to execute a task. 
    * In C# this takes the form of interfaces and abstract classes, logical structures that obstruct the end user's access to the underlying logic.
* Polymorphism
    * Literally means "many forms".
    * When you present the same interface but the inputs/data types used are going to differ.
    * Ability to substitute different implementation details for different needs
    * Ability of an object to take on many forms
    * Implementations
        * Ad Hoc
            * defines a common interface for an arbitrary set of individually specified types
            * Coercing types, overloading, or overriding
        * Parametric
            * when a type can be declared abstractly so aspects of its implementation can be declared at runtime through the use of a parameterized type
        * Inclusion (Sub-typal)
            * when a name denotes instances of many different classes related by some common superclass
            * Covariance: a child class can be treated like it's an instance of its parent class
            * Contravariance: a parent class can be used in place of a child class
* Inheritance
    * The mechanism of basing an object or class upon another object or class, retaining similar implementation
        * Establishes an "is-a" relationship between objects
    * Promotes code reusability
    * In C# the constructors are inherited from parent to child
    * C# does not support multiple inheritance for classes, but you can inherit multiple interfaces.
    * **Other Object relationships:**
        * Composition: (Has-a) a relationship between two or more objects where one object maintains instances of other objects.
            * An Order has many Line Items. Each Line item only exists with that order in place.
        * Aggregation: (Has-a) a relationship between two or more objects where one object contains multiple instances of other objects.
            * A Dog has many Hair objects, a Gun has many Bullets, but those Hairs and Bullets exist without their aggregate objects. Hair still exists when it falls off. Employees exist outside of their employer Company.
        * Association: (uses-a) a relationship between two objects where one objects uses a separate instance of another objects as a part of its functionality.
            * A computer uses a keyboard, but they exist separately from each other. Two Customers might be married, and that may affect part of your business logic, but mostly they are separate.
* Encapsulation
    * Treat related data/behavior as a single unit/piece.
    * The validation and any processsing of the data in your data classes would be done in the class itself.
    * Implemented via data hiding (using access modifiers) and wrapping (grouping logic in classes, assemblies, and namespaces).
    * Wrapping focuses on encapsulating the complex data in order to present a simpler view for the user (i.e making a class that contains multiple smaller related pieces to make things make sense)
    * Data hiding focuses on restricting the use of data, to ensure data security.

## Application monitoring (breakpoints, debugging, logging, tracing)

## Test-driven Development [TDD] (code coverage, unit tests, mocking)





# Day 4

## Serialization (FileIO, Regular expressions, Serializer-JSON/text/XML)



# Day 5

## Design patterns - singleton & factory

## Delegates (Action, Event, Function, lambda, LINQ, Predicate)

## Multithreading (Async/await, Task, Thread)

## Variance (As, Boxing, Casting, Contravariant, Covariant, Invariant, Is, Out, Ref, Typeof)