# Service Oriented Architecture (SOA)
- Architecture style for building software applications that use services available in a network such as the web
- **Services** are an implementation of a well defined business functionality
- So what we want to do is to delegate the whole business logic with the data layer associated with it as a service that returns to the client the necessary data it would need to present to the end user, how to present that data is wholly up to the client.
- SOA relationship: There is a Service Provider and Service Consumer. Both components interact with each other via **messages** (text,json,xml) over a **protocol** (HTTP, TCP, MSMQ, named Pipes)

## Principles of SOA:
- Standardized Service Contract: A service should have a service description document. Eg: [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-3.1) for REST APIs, and [WSDL](https://www.tutorialspoint.com/wsdl/index.htm).
- Loose Coupling: each service should be designed in a way that it is a self-contained component and has minimal dependencies on other services.
- Abstraction: Need not expose the Service internal logic, but it should be defined by its description. 
- Reusability:
- Autonomy: Services are encapsulated in terms of logic and the consumer doesn't need to know about the implementation
- Discoverability: 
- Composability: Using services as building blocks, for sophisticated and complex operations.

## Advantages of SOA:
- Service reusability
- Easy to check operability
- Platform independence
- Availability
- Reliability
- Scalability
## Disadvantages of SOA:
- Load balancing
- High costs and investments involved
- High Overload
- High overhead

## SOA can be implemented in 2 ways:
- SOAP Service: A web service which uses XML format to exchange messages over various protocols (HTTP(s), TCP, MSMQ, named Pipes)
    - Communication between consumer and provider happens on SOAP Packet (XML data)
    - Windows Communication Foundation is used in .Net Framework
        - Service Contract
        - Operation Contract
        - Data Contract
            - Data Members
- RESTFul Service: Asp.Net core web API

## Why industries prefer REST over SOAP service
- lightweight messaging using JSON
- Easy set up and extendability for REST services
- Statelessness helps with scalability
- Reachability because of HTTP, as there are more devices supporting HTTP