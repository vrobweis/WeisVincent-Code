# Access Modifiers
* change the behavior and scope of types or types members
* Scopes Modifiers (Encapsulation)
    * private (default for member types, accessible only by containing class)
    * protected (accessible by the same class and child classes)
    * internal (accessible by the same assembly but not by others)
    * public
* Properties
    * Getters and setters (Microsoft calls them smartfields)

# Extended Modifiers
## Abstract
* means the thing being modified has a missing or incomplete implementation
* intended only to be a base class of other classes, not instantiated on their own
* classes, methods, properties, indexers, and events can be abstract
* members marked as abstract must be implemented by non-abstract classes that derive from the abstract class
* abstract classes:
    * can't be instantiated
    * can contain abstract methods and accessors
    * must provide implementation for all interface members 
    * It can't include the sealed modifier, because why prevent inheritance when an abstract class/method is meant to be inherited?
* abstract methods: 
    * are implicitly virtual methods
    * only permitted in abstract classes
    * do not have {} or a method body
    * only have implementation in derived class methods using override
    * cannot have static or virtual modifiers
## Virtual
* Virtual is used to permit overriding of a method, property, indexer, or event declaration
* This allows the implementation of a virtual member to be changed by an overriding member in a derived class
* Cannot be used with static, abstract, private, or override on the same member
## Sealed
* Prevents inheritance from a class
* Prevents an overriding method from being overridden again.

## Static
* Static classes:
    * cannot be instantiated or extended
    * implicitly sealed
    * all their members must be static
    * essentially a static container for static members
* ALL Static Members:
    * cannot use 'this' to reference static methods or property accessors
    * Belongs to the class type itself rather than the specific object instance
    * a static member is referenced through the type name, not an instance
## Const
* Constants are not variables, they cannot be modified.
* can be numbers, Boolean, strings, or null.
## Readonly
* Can only be initialized as part of the declaration or in a constructor in the same class
## Override
* Required to extend or modify the abstract or virtual implementation of an inherited method, proerty, indexer, or event
## Partial
* You can split the definition of a class, struct, interface, or method over two or more source files. Each source file contains a section, and are then combined on compilation.
* This is useful if the source code is automatically generated, you can add code to the class without having to recreate the source file. Visual Studio does this when it creates Windows Forms, Web service wrapper code, and so on. 
* Attributes, inherited classes, etc., are merged at compile-time.

## Async
## Await