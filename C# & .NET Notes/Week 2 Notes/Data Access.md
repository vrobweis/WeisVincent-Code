# Data Access
Getting the data you want

## Select Statement
* Used to retrieve data from the database
* Select statement clauses
    * Select: Specifies what columns to have in the result set
    * From: Specifies what table to query
    * Where: Defines a condition to filter out rows that don't match
    * Group by: Aggresgates multiple rows into one, if they have the same values for all the expressions in the group by list
    * Having: defines a condition for filtering after group by
    * Order by: specifies the sort order of the result set
* Logical order of operations to the select statement: 
    1. From
    2. where
    3. group by
    4. having
    5. select
    6. order by

## Join
* Combine data back together in a query that was spread out into many tables by the DB design
