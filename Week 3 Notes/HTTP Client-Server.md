# HTTP

## Requests
* From client to server
#### 3 Parts
1. Start line
    - Method: the action to be performed
        - Safe methods: These are safe methods because they don't change resources or data, they just get information
            - GET
            - HEAD
        - Idempotent methods: a method is idempotent if the state of a resource/data is only affected once by this method, meaning even if you make the same call with the same inputs, it'll only happen once
            - POST
            - HEAD
            - PUT
            - DELETE
    - Target: Where to send the request
2. Header
    - Meta data
    - Ex: content type: what data type the body has
3. Body
    - Data you want the server to process

## Response
* From server to client
#### 3 Parts
1. Status line
    - Contains HTTP status codes of describing what happened when interacting with the server
        - 1xx: informational
        - 2xx: Communicating success
        - 3xx: redirection
        - 4xx: errors that are the client's fault, client side errors
        - 5xx: errors that are the server's fault, server side errors
    - Headers
    - Body