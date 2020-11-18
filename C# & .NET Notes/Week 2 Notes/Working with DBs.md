# Working with DBs

## Object-Relational Mapper
* In Databases, data is stored in tables, rows, columns.
* There needs to be something that converts data from a DB into programming objects
* ORMs are used to answer this problem by makking data from a DB into an object in your program
* We will use Entity Framework Core

## Entity Framework Core
* ORM for .Net Core
* 2 ways to connect your DB to your C# code
    * Code first: Create DB structure based on the classes in the code
        1. Create Entities/Models (Use naming convention to ease the migration process)
        2. Create implementation of the DBContext
        3. Run dotnet ef migrations add &lt;name of migration&gt; -c &lt;implemented db-context&gt; --startup-project &lt;location of startup project&gt;
        4. Run dotnet ef database update --startup-project &lt;location of startup project&gt;
        5. Repeat steps 3-4 for any changes to your db
    * DB first: The DB structure already exists, classes are created based on the existing structure
        1. Have a data access library project separate from the startup application project
        2. Install Microsoft EF Core Design and PostgreSQL to both projects
        3. Run the long scaffold code
            * dotnet ef dbcontext scaffold -c &lt;connection-string-in-quotes&gt; -providerNpgsql.EntityFrameworkCore.PostgreSQL --startup-project &lt;path to project folder&gt; --force --output-dir Entities
        4. Delete the DBContext.OnConfiguring method from scaffolded code
        5. Anytime you change the structure of the tables, go to step 3

## Artifacts we'll be working with
* DBContext
    * A DbContext instance represents a session with the database and can be used to query and save instances of your entities
    * We need to make our own implementation of this that is specific to our app
* Connection String
    * Used to connect to your db
    * Contains information about the database you'll be connecting to
* Startup project
    * The one that the tools build and run
* Target project
    * The built, compiled app
* ADO.NET is used to provide access between relational and non-relational systems