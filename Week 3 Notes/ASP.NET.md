# ASP.NET
* Active Server Pages
* **History**
    * .Net Framework (2002) had Asp.Net Forms, using an old SDLC model called Rapid Application Development (RAD)
        * Asp.Net Forms had drag and drop capability, making it easier to make applications quickly
        * The model was fat and unmanageable, the ASP.Net Forms weren't great
        * tight coupling: The front end code was tightly coupled with server side code, making it non-testable
        * less separation of BL from UI 
    * .Net Framework in 2010 introduced Asp.Net MVC, based on the MVC design pattern
### MVC Design Pattern
* Models: That contains structure of data, data validation, and data business logic such as constraints on databases.
* Views: UI Logic
* Controllers: The component which handles users requests

### .Net Core -> Asp.Net Core
* You can create either:
    * Asp.Net Core MVC app (Web application with UI)
        * MVC
        * Razor Pages
        * Blazor
    * Asp.Net Core Web API (Service application for creating RESTful services that you can slap any UI onto)
* Asp.Net Core is compatible with all environments
* **Hosts**
    * IIS (Microsoft's server, Windows only)
    * Kestrel (Platform independent server)
    * HTTPS.sys
    * Nginx
    * Apache
    * Docker

## ASP.Net MVC
### Controllers
* Handles all user interaction
* A controller class inherits Controller class from Microsoft.AspNetCore.Mvc
* All public methods in controller class are called **Actions**
* Actions can be two types:
    * GET actions: will return something like a view
    * POST actions: Used to submit some user input
### Actions
* Methods that handle forwarded requests from the controller
* Typically have a return type of **IActionResult**
    * From IActionResult, you can return various outputs
        * ViewResult: a view, using View() {also, PartialViewResult}
        * JsonResult
        * FileResult
        * ContentResult
        * ActionResult

### Passing data to views and controllers
* Controllers to view data can be passed in 2 ways:
    * Weakly-typed: 
        * ViewData: Dictionary-like object where you pass a key and the value which needs type casting for complex data
        * ViewBag: dynamic type object which doesn't need casting for complex data. It's a wrapper over ViewData.
        * TempData: 
            * ViewBag and ViewData can only pass values from controller actions to a View, not between controllers
            * Used to pass data from one controller to another. 
    * Strongly-typed:
        * By using Models in the views, called view-models
        * 1 view is tied to only 1 model
            * You can nest models into one aggregate model that contains the others to pass multiple models into a view
    * Dynamic-typed:
        * Cast to dynamic type that ASP.Net handles at runtime, which limits IntelliSense-like features that give you some information but will work at runtime

### Views
* Consists of UI Logic
* Supports C# and HTML
* C# code is accessed with @ tag for one line code
* `
@{
    multiple lines of C# code 
}
`
* Types of Views
    * Weakly-Typed
    * Strongly-Typed
    * Dynamic-Typed
    * Layout View: Implements principle called DRY (Donot Repeat Yourself)
    * Partial Views (think more child views of a parent view, not so much partial class in C#): 
        * These allow us to break up component parts of a page. 
        * In Razor Pages, markup files are called pages, but in MVC apps, markup files are called views

### Model Binding
* A mechanism that's part of ASP.Net Core that allows the values of parameters action methods to be binded to a from different locations of that data:
    * RouteData
    * FormCollection
    * QueryString
    * File

## Routing
* Mechanism to implement powerful and meaningful URLs and its mapping
* Performed by Routing Engine
    * The engine has a route table that maintains the repository of the patters, controller, actions, and each action's parameters.
* Because of routing, link generation is independent of the file structure.
* Routing can be done in two ways
    * Conventional based way: globally defining routes (try looking at startup.cs)
    * Attribute based routing

## Lifetime of the context
* There are built in Inversion of Control(IoC, think Dependency Inversion Principle) containers that manage the lifetime of a registered service (Like the DbContext)
    * Singleton - service will be available throughout the lifetime of the application, single instance.
    * Transient - It will create a new instance of the specified service type everytime you ask for it.
    * Scoped - it will create the instance of the specified service type once per request and will be shared in a single request.

## Helpers in MVC Views
* 2 Types of helpers which can be used to generate HTML at runtime by the Razor Engine
    * HTML Helpers: C# methods which create the HTML at runtime
    * Tag Helpers: more like mark ups and HTML friendly syntaxes, like attributes

## Validations
* To check the user's input client side as well as Server side, we use validations
* Data annotations: Can be used to:
    * perform client side validations using annotations like StringLength/Range, RegularExpression, Required
    * Display Views: Datatype, Display Name
    * Mention schema logic: Key, Foreign Key, Required