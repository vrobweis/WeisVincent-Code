# Design patterns

## Singleton Design Pattern:
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

## Factory
* One Class generates multiple instances of another class
* ???????????????????????????????????????????
## Repository 
- Container where data access logic is stored
- Separate logic that retrieves and manipulates data in your DB and maps it (entities of DB to entities of BL) to logic that acts on and with your Business Logic
- You want your BL to be agnostic of whatever data storage system you might have
- Implementation:
    - Data/DB/Data Access/Persistence layer
    - Repository/ Mapper classes

## Facade
- Creating a facade to hide the complex subsystems (if they exist) that implementation might depend on, so that it's easier to access the necessary methods you would need
- Implementation
    - Creating an interface that encapsulates these subsystems (if they're interfaces as well)
    - ex: A Repo interface that combines the CustomerRepo, ManagerRepo, ProductRepo interfaces in an easily referenced interface, that contains all the necessary methods