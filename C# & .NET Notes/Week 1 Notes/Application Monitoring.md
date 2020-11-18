# Application monitoring 
* Breakpoints
* Debugging
* Logging
* Tracing

Application monitoring is highlighting certain events that come up during runtime of your program by pausing execution or recording the occurence. This is useful in finding points of failure (debugging)
## Breakpoints 
* During development, you can add breakpoints to certain lines of your code so that when you do a debug run, the program pauses its execution at that point
* When hitting a breakpoint, you can:
    * Check the values of any variables in scope
    * Continue to the next breakpoint
    * Step over a function that is called
    * Step into a function that is called
    * Step out into the original line that called the function
## Logging
* Practice wherein certain events during runtime are recorded
* Events that warrant a record:
    * Errors
    * Business logic events (Such as logging in)
    * Transactions with external systems (like performing actions on a database)
    * Many other conventions
* Logging Levels
    1. Verbose: Anything and everything you might need to know about running a block of code
    2. Debug: Internal system events that aren't necessarily observable from the outside
    3. Information: "Things happen"
    4. Warning: Service is degraded or endangered
    5. Error: Functionality is unavailable, invariants are broken, or data is lost
    6. Fatal: Very severe events that will lead the application to abort
* Where logs are kept:
    * Files
        * .txt, .xml, etc
        * Depends on your log configuration
    * Databases
    * Console (How dare you.)
    * Et Cetera
        * Note: Research logging software that eases sifting through production level logs.
## Tracing
* Confused with logging since they use similar software
* Used to track a user's interaction with the system
* Unlike logging that shows events that occur during runtime, tracing is highly involves with debugging and includes information such as which functions are called and what parameters were provided during the time the user interacted with the program.
* You would then go through the same steps as the user to find where the bug occurs, and any methods that throw an error during tracing would be logged.

