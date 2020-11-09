# ASP.Net Core Web API
- Content Negotiation: The process of selecting the best representation (JSON, XML, etc.) for a given response when there are multiple representations available. Whenever the client request data using the Accept header, basically. (Default for ASP.Net Core uses JSON.)
- In HTTP, the primary mechanism for this negotiation are request headers:
    - Accept:
    - Accept-charset:
    - Accept-encoding:
    - Accept-language:

## How can you consume an ASP.Net Web API
1. Client-side: Using JS or any frameworks based on client-scripting language
2. Server-side: HttpClient