# Runtime Environment Notes

## Common Language Runtime (BCL, CIL, CLI, CLR, CTS, JIT, VES)
* The CLR is the .NET Framework's implementation of a Virtual Execution System (VES). It defines
    * a hypothetical machine with an associated machine model and state
    * a set of control flow constructs
    * an exception handling model
* https://en.wikipedia.org/wiki/Common_Language_Infrastructure
    * C#, F#, VB can all be used with the .CLI Microsoft made for .NET
    * Each language still uses their own compiler but compile into the Common Intermediate Language, formerly called Microsoft Intermediate Language (CIL/MSIL), compiled by the Just-In-Time Compiler (JIT), and then that code is passed to the runtime (Common Language Runtime)
* When you compile, you can either make a library (.dll) or an executable assembly (.exe)
### Common Type System (CTS)
* The Common Type System (CTS) is used by the CLR to enforce strict typing and code verification, even between the disparate .NET languages.
    * The CTS is the middle man between various languages. (i.e. CTS uses System.Int32, C# uses int, VB uses integer. CTS uses System.Int16, C# uses short, VB uses foo.)
    * Common Type System used to ensure a common mapping or standardization for types in each language
* Common Language Specification ensures that each .NET compliant language follows certain rules (such as OOP or the starting index number for arrays and the like)

## Memory Allocation
* Stack memory
    * Faster
    * Stacked and easily accessed
* Heap memory
    * Clusterf pile of data that isn't as easily accessed
* Value types store directly in the stack, reference types store an address in the stack, and the value in the heap

## Garbage Collection
* Garbage collection is when the virtual execution system frees the memory of objects in the managed heap that isn't being used.
### Benefits of Garbage Collection
* No memory leaks.
* Efficient memory allocation.
* GC automatically reclaims unused objects, clears memory, and makes memory available.
* Constructors do not have to initialize every data field.
* GC makes sure that one object cannot use the contents of another object.
### Memory fundamentals
* Each process has 2GB of virtual memory allocated. In C# you can't decide where or how memory is allocated during the process.
* The garbage collector (GC) allocates and frees memory.
* Virtual memory has three states:
    * Free: unallocated, available
    * Reserved: Available, unusable for other processes, must be committed to store data
    * Committed: assigned to physical storage
* The frequency of garbage collection depends on the volume of allocations and amount of survived memory on the managed heap
### Managed Heap
* The GC allocates a segment of memory, called the Managed Heap, to store and manage objects
* One Managed Heap for each managed process
* The GC calls the Windows VirtualAlloc() to reserve memory and VirtualFree() to release memory
* The GC divides objects into small objects (instances) for the Small Object Heap (SOH) and large objects (arrays) for the Large Object Heap (LOH).
### Heap Object Generations
* Garbage collection happens on a whole generation at once.
* Objects that survive a GC are promoted to the next generation ( -> G0,G1,G2)
* When GC sees that survival rate is high, more memory is allocated for that generation
* After GC, survivors are compacted (defragmented) to the older end of the memory segment

## Managed Code 
* (https://lh4.googleusercontent.com/ba0t4YUhByJJM5zZUS0y5Yf8bje8Lg65CRIRfTX706TNfhgQKlsU4A4H9lHY5KNxl87pBVi6R-amliVN2Y_wn_IdpvemqU36NC1atanq8eHearBlTmKm929X2Kl_AwShDQRlQuY)
* Managed Code is code managed by the CLR at runtime.
* The CLR provides memory management (GC), security boundaries and type safety
* Managed code is written in high-level languages on top of .NET
* Code is compiled into Intermediate Language (IL, MSIL, CIL) code, which the CLR compiles and executes
* CLR manages the JIT compiling code from IL to machine code that can be run on ANY CPU.
* The CLR knows what your code is doing and can manage it.

## Unmanaged Code
* Code that runs outside the CLR is called Unmanaged
* .NET Framework promotes interaction with COM components, services, external type libraries, and many OS services
* Data types, method signatures, and error-handling mechanisms vary between managed and unmanaged object models
* Examples:
    * COM components
    * ActiveX interfaces
    * Windows API functions
* IDisposable interface
    * The GC has no knowledge of unmanaged resources such as:
        * window handles
        * open files
        * streams
    * IDisposable provides a method for releasing unmanaged resources.
        * If your app uses an object that implements the IDisposable interface, call the object's IDisposable.Dispose() implementation when finished using it.
    * Using Block
        * You can use 'using' instead of calling IDisposable.Dispose() yourself. The using statement is a syntactic convenience. At compile time, the language compiler the Intermediate Language for a try/finally block where .Dispose() is called in the finally block. 'using' is essentially just shorthand.
        * This ensures correct implicit usage of the Dispose() method, and makes sure it's called even if an exception occurs that would prevent Dispose() execution. It prevents memory issues when using unmanaged code that the CLR doesn't handle. 
