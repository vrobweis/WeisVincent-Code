# .NET
.NET is a platform to create apps (Console app or CUI, Windows Desktop app or GUI, API, microservices or cloud services, IOT, game development like Unity)
made in 2002 -> .net Framework 1.0
## .NET in 2020
* more than the original Windows framework
    * The Windows .NET framework
    * .NET Mono for MacOS
    * In 2016 the Core .NET Framework was developed to be platform independent
    * Xamarin, used for mobile apps. 

## Components of .NET Core SDK
* comes with dotnet CLI(command line interface, lets me use 'dotnet' in the command prompt)
* dotnet libraries (standard libraries)
* runtime/Common Language Runtime (CLR)

## Assembly vs Namespace
* Namespaces logically arrange the types (classes) to avoid naming conflict
* Assembly is a deployable unit that can be considered a physical separation of types (classes) -> .exe or .dll 

## App Structure
* Most Apps have a UI layer, a Business Logic layer (BL), and a DB layer (data base)
* Layers are a logical separation of code (UI layer, BL layer, etc.)
* HelloWorld is a 1-tier App, because it has one layer.
* N-tier Apps are most new business apps which have multiple servers to deal with different layers and different connections between non-adjacent layers. These individual projects in one big business solution are called microservices. (Think Adobe Creative Suite. spiderweb bulls-)
* .NET Solutions are used to group multiple projects together (Think MVC or modules, compartmentalizing smaller parts of the big business solution) 
    * {mkdir &lt;solution name>; cd &lt;solution name>; dotnet new sln}
    * UI: Console/UI project, BL: Class Library project, DB: Class Library project