# Database Design
## Constraints
In creating tables, columns can have constraints, used to set guidelines in what data belongs in what column
* Data type
* Not Null
* Unique
* Check
* Exclusion
* Primary Key
* Foreign Key
## Keys
Keys are used to uniquely identify a data set, and also to establish relationships between entities
* Candidate key
    * Minimal set of columns in a table that every other column depends on
    * The values of any candidate key can uniquely identify a row
* Primary key
    * Unique identifier for a row in a table
    * In implementation we choose one candidate key to identify the row
* Foreign key
    * A set of columns which hold the values of some primary key to establish a relationship to another row/table
* Composite key
    * Any key that's more than one column

## Referential integrity
* Refers to the accuracy and consistency of data within a relationship
* whenever a foreign key value is used it must reference a valid, existing primary key in the parent table
## Defining relationships in SQL
* Relationships in SQL are defined by multiplicity
* 1:1
    * This means that two sets of data are unique to each other
    * an apprentice can only have one master, one master can only have one apprentice
    * Put both entities in the same table or separate the entities in two tables with a FK reference that is Unique and Not Null
* 1:m
    * A Pre-K teacher can have many students, but students have only one teacher
    * Two tables, FK that is not unique
* m:m
    * A college student has many professors, and professors have many students
    * 3 tables, one of which is a join/junction table

## ER Diagram
* Shows the relationships of entity sets stored in a database
* Visual representation of your DB Design

<img src="ER Diagram Example.png"
     alt="ER Diagram Example"
     style="margin: 10px;" />

## Why separate out data?
* Can't insert some data without having some other data
* Forced to delete some data in order to delete other data
* Redundancy means accidental consistency when updating

## Normalization
 Defined as designing a database in a certain way to ease data management
* 1NF
    * Atomic Values
    * No repeating groups of columns
    * No duplicate rows
* 2NF
    * Has to be 1NF
    * No partial dependencies
    * No composite keys mean you're 2NF by default, but 2NF isn't about composite keys, it's about partial dependencies
* 3NF
    * Has to be 2NF
    * No transitive dependencies