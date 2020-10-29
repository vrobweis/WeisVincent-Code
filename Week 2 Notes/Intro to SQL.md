# SQL Sublanguage vs SQL Dialect
## SQL Dialect
* Refers to the SQL Variant used by a DB vendor. (PGSQL for PostgreSQL)
## SQL Sublanguage
* Refer to different categories of statements/commands in SQL
* In Postgre there are 4 sublanguages (DDL,DML,DCL,TCL)
    * Data Definition Language (DDL)
        * Used for creating database tables, defining the DB Structure
        * Create, Alter, Drop
    * Data Manipulation Language (DML): All operations on individual rows
        * Select (technically Data Query, not Manipulation)
        * Insert
        * Update
        * Delete: Deletes rows with history to allow rollback
        * Truncate: Deletes rows without any history
    * Data Control Language (DCL): For DB Admin, allow users to have different permissions
        * Grant
        * Revoke
    * Transaction Control Language (TCL): Concerned with grouping SQL commands and executing them as a batch
        * Commit
        * Savepoint
        * Rollback
        * Transact