# Transactions
* Unit of work that either succeeds or completely fails
* Used to describe a group of queries that are executed as a batch that should completely succeed or not have any effect on the database at all
* ACID: The characteristics of a transaction
    * Atomicity: All or nothing execution, it either succeeds or sucks mud through a silly straw and fails
    * Consistency: Only valid data is saved, guarantees committed transaction state, and that it isn't half finished
        * only data following all rules and constraints is written into the database
    * Isolation: Transactions do not always affect each other (Isolation levels make this negotiable)
        * Transactions generally are separate from other transactions
        * Isolation levels define the degree to which a transaction must be isolated from the data modifications made by any other transaction in the database system
        * Ways other transactions can affect your transaction    
                * Dirty Read: when your transaction reads uncommitted updates done by another transaction
                * Non Repeatable Read: when your transaction reads committed updates done by another transaction ( a row's value differs between sequential reads)
                * Phantom Read: Some rows may be added or removed due to updates done by another transaction ( a collection of multiple rows differs between reads, even if the values of the persisting rows is the same)
        * **Degrees of Isolation**
            * Read uncommitted (zero isolation)
                * No protection
                * Useful for when you read and write all the time, like Netflix, or if you're tracking number of covid cases, you can just reload
            * Read committed
                * Protects transaction from dirty read by not from non repeatable read, meaning you can still read committed data from other transactions
                * locks updates unless committed
                * Think getting concert tickets
            * Repeatable read
                * Protects transaction from non-repeatable read by not from phantom read
                * When querying batches of data you'd still be able to get a different set of rows when you query the table before and after updates from another table occur
                * Locks row
            * Serializable
                * Protects transaction from phantom read. 
                * Highest isolation level
                * Essentially locking the data from other transactions
    * Durability: Written data will not be lost