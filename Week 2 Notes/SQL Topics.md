# SQL Topics

## Functions
### Scalar Functions
* Returns a single value
* Some built in functions to deal with strings:
    * lower()
    * upper()
    * substring()
    * char_length()
* Built in functions to deal with Dates and Numeric values
    * FORMAT(column name, format) : determines how text fields are shown
    * ______________
### Aggregate Functions
* Perform calculation on multiple tables or values and return a result (that is an AGGREGATE of the original values)
### Tabular Functions
* Functions that return a value of type table, meaning you can treat the function as a table, since it returns a table

## Triggers
* Trigger is a named PL/SQL unit that's stored in the DB and can be invoked multiple times
* Triggers can be enabled (DB automatically invokes it) and disabled (trigger does not fire), but not invoked.
* Triggers can be fired in reaction to:
    * DML commands
    * DDL commands
    * LOGON commands
* They let you
    * Gather stats on table access
    * Prevent DML operations
    * ________________
* When do they execute?
    * Events - DML
    * Before triggers: invoked before an event occurs
    * After Triggers: invoked after an event
    * instead of triggers: invoked instead of the event that would otherwise occur

## Views
* A view is a virtual table based on the result set of a SQL query
* can show all the rows of a table or specific rows based on conditions
* Shows specific fields to an end user- promoting security and hiding complexity
* They can get the information you want quickly, but it isn't as quick as tables in changing data, because they don't hold the data
## Indices/Indexes
* Special lookup tables that store data physically and speed up data retrieval
* Indexes can be created and dropped without affecting data in any way, and do update when the data is changed
* Should be used when you are using a lot of WHERE clauses to filter data, and you are not maipulating the data, just retrieving it
* Shouldn't be used if you have small tables, columns with null values, tables with a lot of updates or insertions, _______
* Clustered vs Nonclustered index: Clustered indices defined the oder in which data is physically stored. Primary keys, for example, would be used to order the data. Nonclustered, on the other hand, are more analogous to an index in a textbook, where you can have multiple indices to one sections, and are not organized to mirror the physical data.
* Types of Indexes (https://www.besanttechnologies.com/sql-indexes)
    * Single-column: Based on only one table column
    * Composite: On 2+ columns, good to use when you use multiple columns to filter data
    * Unique: Used for data integrity, doesn't allow duplicate values
    * __________________