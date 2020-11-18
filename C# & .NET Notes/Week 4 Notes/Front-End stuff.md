# HTML
- Hypertext markup language
- This defines the structure of the web
- What goes where
- Use tags to describe the elements of your webpage

## How is your webpage read by the browser?
### Steps:
1. Request
    - Client requests
2. Response
    - Server responds
3. Build
    - Browser builds
4. Render
    - Browser renders the webpage for you
[More..](https://www.google.com/url?q=https://varvy.com/pagespeed/display.html&sa=D&ust=1605034532504000&usg=AOvVaw2hEs16F-Y3LK32s_7qjimy)

## HTML Versions
- HTML5 is the standard
- HTML has gone through revisions, including even xhtml, which introduced errors onto the page.
- The Web Hypertext Application Technology Working Group (WHATWG) is in charge of maintaining this standard

## Semantic Elements
- HTML5 introduced semantic elements
- These are elements that clearly describe their meaning in a human readable way

# CSS
- Stands for Cascading Style Sheets
- Applies style in webpage using cascading algorithm (Style is applied in layers)
- Since html describes the structure of the webpage, CSS describes the style

## How styles are applied
- CSS styles use rules to apply stylings to a webpage.
- Rules are a key-value pair of what element property to style, and the style that should be applied.
- Selectors are used to group these rules together, and define a set of style rules for a certain group of elements

## Ways to Include CSS
1. Inline
    - Uses style attribute of html tags
2. Internal
    - Uses style HTML tag found in header
3. External
    - Uses totally separate .css file
    - referenced in head
    - Best practice for separation of concerns

## Responsive Web Design
- Designing pages so they render well on any window.
- Bootstrap JS lets you forget this mostly
    - CSS Framework
    - Responsive, mobile first
    - Used when you really can't art (standard css classes to style your webpages)
    - using the Bootstrap classes on html attributes allows for easier styling

# Javascript
- JS for short
- Javascript is NOT Java. Javascript is completely different.
- Functional language, with a little OOP support. There are objects, I guess
- Loosely typed (It has data types but that doesn't mean it doesn't have data types)
- Interpreted, not compiled
- ECMAScript is the Standardization of JS
- Just like how HTML has HTML5, ECMA6 is the newest JS version

## Sunbons: Datatypes in JS
- Symbols
- Undefined: an undefined variable, with no value
- Null: a value of null, nothing
- boolean
- Objects
    - Functions are a separate data type but they are treated as objects
- Numbers
- Strings

## Scopes
- Function
- Global: if you use var, because of hoisting, the variables will have a global scope
- Block: use let, not var to limit the scope

## Truthy and Falsy
- In JS all values have a boolean equivalent, meaning you can evaluate actual values instead of just boolean expressions
- Falsy: values that evaluate to false (FUNONE)
    - False, undefined, null, 0, NaN
- Truthy: values that evaluate to true (everything else)

## Functions in JS
- Callback function
    - function within a function
- arrow function: Anonymous function/ think Lambda expressions in C#
- IIFE: immediately invoked function

## Encapsulation in JS
- Since JS is not an object oriented language, it doesn't have access modifiers, but you can still achieve encapsulation using closure
    - If you have a function within a function, the inner function is the only one that can access scoped variables (let x...)

## Inheritance in JS
- Before ES6:
    - Classes didn't exist, so you didn't inherit from a parent class.. but..
    - Prototypal inheritance:
        - When you try to access a property on an object that isn't found, the JS engine will search for it in the prototype and then on the prototype's prototype and so on.
        - Only applies for access and not assignment
    - ES5 added constructors
- In ES6, you can create classes, and use method syntax
    - use the extends keyword to implement inheritance in JS

# DOM
- Document Object Model
- Representation of your HTML document as a tree (made up of nodes) that can be modified using JS
- Used to change document structure, style, and content at runtime
- Use selectors to identify elements in your DOM
    - document.getElementById()
    - document.getElementsByClassName()
    - document.getElementsByTagName()
    - document.querySelector()
    - document.querySelectorAll()


# Dynamic Web Design
- A web page is dynamic if it reacts to user interaction
    - For example, clicking a button should be able to result in something occurring in your web page
    - If you ahve a web page that does not change with user interaction then the web page is static (and boring)
## Events
- Any type of interaction with the webpage, like the user clicking a button
- Any significant change in page state (when elements have been loaded)
- Event Handlers
    - Functions that get called when an event happens
- Event listeners
    - Added to elements, call an event handler when a certain event occurs

# AJAX
- Technique used to update your page with information from the server without reloading it. It used to just use XML but can now use more.
- XMLHTTPRequest
    - Main actor that sends and receives the request to the server

## Fetch API
- JS interface for making http requests and processing server responses
- Uses **promises** to achieve asynchronosity
    - You can set up different logic to handle if the promise rejects or fulfills.