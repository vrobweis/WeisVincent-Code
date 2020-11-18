# Multithreading
## Deadlock
* Deadlock occurs when concurrent tasks are waiting on each other to progress in execution.
* 4 conditions must be true for deadlock to occur
    1. Mutual Exclusion (If one thread owns a resource, another thread cannot acquire that resource)
    2. Thread Holding a resource is able to perform an Unbounded Wait (meaning a resource never has to be released from use)
    3. Resources cannot be forcibly taken away from their current owners
    4. A circular wait condition
* Handling Deadlocks
    * Ignore (dont)
    * Detect and resolve
    * Prevent
* Fix the deadlock with:
    * Rolling back and trying again (If deadlock occurs due to held resources, roll back the acquisition of the resource, wait for it to be free again, then move forward)
    * Steal resources temporarily
    * Kill one of the threads in waiting

## Starvation
* Starvation occurs when multiple threads are poorly scheduled and switch between certain tasks and don't allow other tasks to proceed. The program may move forward but not necessarily the way it should.

## Dining Philosophers Problem (D.P.P.)
* The DPP is a synchronization and resource allocation problem (Example of 5 philosophers at a table with a left and right chopstick shared with adjacent philosophers, and how to keep them perpertually alternating between eating and thinking)
* results in resource starvation and mutual exclusion

## Race Conditions
* occurs when two or more threads can access shared data
* Can be solved by making variables atomic, or using locks

## Critical Section
* Section of code where shared variables can be accessed
* must be synchronized (run Atomically)


## Thread Safety
* Confinement: Keep mutable data confined to a single thread
* Immutability: Only ues immutable references and data types
* Threadsafe Data types: Use built in libraries to ensure mutable data shared between threads is protected from race conditions (System.Collections.Concurrent)
* Synchronization: Mechanisms for monitoring mutable data shared between threads
