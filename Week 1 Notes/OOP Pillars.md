# OOP Pillars (A PIE)

## Before the Pillars..
### Interfaces
* Think contracts. Interfaces contain definitions fora group of related functionality, which a non-abstract class or struct must implement. A Dog might implement a living interface, for example.
* These can't be instanced, meaning you can't make an object of this type and fill in fields or properties for an interface. It's a ruleset, not an object. Think like a set of standards for sports in general, not a specific sport.
* No constructors, all method stubs declared within interfaces are implicitly abstract, may define static methods, which then must have at least one implementation.
* From C# Version 8.0 onward, an interface may define a default implementation for members, which allows you to more easily edit an interface or add functionality later on without changing every single class that implements it.
### Abstract Classes
* Classes denoted using the abstract keyword. These CAN have constructors to initialize fields.
* Often they contain unimplemented method stubs, to denote required functionality without forcing a means of doing so. They initiate a structure. 
* May have abstract and non abstract methods
* May have fields
* A dog might inherit from an abstract animal class, for example. There won't be any need for a generic animal without more specifics, but making an abstract animal class allows you to make easily reusable code that applies to any child class.

## The Pillars of OOP
### Abstraction
* A technique for dealing with complexity by simplifying how the users interface with your work
* It splits the functionality needed by the user with the implementation you put forth.
* Hiding the implementation of how data is processed, how logic is executed, and show your end user only the properties/methods they need to execute a task. 
* In C# this takes the form of interfaces and abstract classes, logical structures that obstruct the end user's access to the underlying logic.

### Polymorphism
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

### Inheritance
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

### Encapsulation
* Treat related data/behavior as a single unit/piece.
* The validation and any processsing of the data in your data classes would be done in the class itself.
* Implemented via data hiding (using access modifiers) and wrapping (grouping logic in classes, assemblies, and namespaces).
* Wrapping focuses on encapsulating the complex data in order to present a simpler view for the user (i.e making a class that contains multiple smaller related pieces to make things make sense)
* Data hiding focuses on restricting the use of data, to ensure data security.