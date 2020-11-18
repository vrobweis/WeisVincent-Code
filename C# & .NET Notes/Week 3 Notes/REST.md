With ASP.Net MVC, the view is tightly coupled to the processing code, meaning the client will have to wait for its request to be processed, and also for the view that the server eventually returns.
The solution is to break up that codependency, decouple the logic that processes data and does all that computation (back-end) from the logic that presents data (Front-end).


# REST
- Stands for REpresentational State Transfer
- Architectural style to design your services
- Guiding principles of REST:
    - Client-Server relationship
        - The client app must evolve separately from the server app without any development dependency on each other
        - Decoupling your services from each other
        - Services should be independent from each other, even if they call upon each other
    - Stateless
        - Server isn't responsible for storing client state (Front-end stores client state)
        - The server will not store anything about the latest HTTP request the client has made
        - The server treats every request as new
        - No session, no history in the server
    - Cacheable
        - Resources from the server can be cached if applicable, these resources themselves must declare themselves cacheable
        - Ex of cacheable: Get request
        - Ex of non cacheable: Delete request
    - Uniform Interface: Your Service would have an interface defined by four interface constraints:
        - Identification of resources
        - Manipulation of resources through representations (abstraction)
        - Self-descriptive messages: Responses inclide any necessary information to process the data, such as the format of the data. JSONs, HTML, XML can be used to help with this, so the client can process the information.
        - Hypermedia as the engine of application state (HATEOAS)
            - Using things as simple as URLs and HTTP to interact with the service so Hypermedia can be used
    - Layered System
        - Constraining the interactions of your components to the ones in the next layer
        - Ex: You have an Authorization Service, a subsystem of BL services, and another subsystem of DL Services. The layers would be UI>Auth & BL>DL, UI components can interact with the Authorization service, and access some of the BL components, but it can never access the DL services
    - Code on Demand (optional)

## Richardson Maturity Model
A way to describe how REST-compliant your service is. It grades your API according to the constraints of REST according to levels
- Level 0
    - Uses HTTP, single URI, one method (usually POST)
- Level 1
    - Uses HTTP, multiple URIs, still one method (POST)
    - Unique URI for each unique resource
- Level 2
    - uses HTTP, multiple URIs, various HTTP methods
    - Operations depend on the action method used
- Level 3
    - Uses HTTP, multiple URIs, various HTTP methods, and HATEOAS

# REST vs SOAP
|                  | REST                   | SOAP  |
|------------------|------------------------|-------|
| Protocol         | HTTP                   | Any protocol over HTTP, just uses POST     |
| Format           | Any format, JSON is easier to parse and is lightweight     | XML |
| Statefulness     | Stateless              | Can be stateful    |
| Caching support  | Good caching support   | Supports caching but not at the HTTP level |
| Security support | Just HTTPS, not true end-to-end security  | Lots of security support        |
| Contract basis   | Based on HTTP standards & conventions & is either htpermedia or an API description language | Based on WSDL document  |
| Errors           | HTTP Status codes          | Faults    |