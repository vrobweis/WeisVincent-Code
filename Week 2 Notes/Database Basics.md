# Databases
* An organized collection of structured information, or data, typically stored electronically in a computer system
* Usually controlled by a database management system (DBMS)
    * serves as an interface between the database and it's end users or programs, allowing them to retrieve, update, and manage how the information is organized and optimized 
    * Facilitates oversight and control of DBs, enabling a variety of admin operations such as performance monitoring, tuning, backup and recovery
* Together, the data and the DBMS, along with the apps that are associated with them, are referred to as a database system, often shortened to simply database

## Relational Databases
* type of database that stores and provides access to data points that are related to one another
* based on the relational model, an intuitive, straightforward way of representing data in tables
* Stores data into relations (tables)

## SQL (Structured Query Language)
* A programming language used by nearly all Relational databases to query, manipulate, and define data, and to provide access control
* Used to provide structure to your database
* Declared: Say what we want, not how to implement how to get what we want

## DB Architecture

<img src="DB Architecture.png"
     alt="Database Architecture"
     style="margin: 10px;" />

* Query Processing includes translations on high level queries into low level expressions that can be used at physical level of file system, query optimization and actual execution of query to get the actual result.
* DBMS Engine is the core part of a DBMS that provides access to the data in a DB managed by the DBMS.
