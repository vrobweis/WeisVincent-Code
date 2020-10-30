# ADO.NET
## ActiveX Direct Object
* We use this framework as a middleware to connect Application Logic program to backend
* There are two architectures in ADO.NET
    * Connected Architecture
        * Both application and backend are both active and interacting (message service, which needs the backend to be ready for messages)
        * Reading from data happens when client app and backend are live
        * Reading happens in forward only directions (like a for loop), no backtracking
        * ?????????????? Lazy Loading ?????????????????????
    * Disconnected Architecture
        * Fire and forget the query
        * Once the connection is made the backend would send results to the client, which are stored locally (local stored data is called Dataset)

To connect your app to a DB there are 3 basic steps:
1. Create a connection
2. Fire a query
3. Get results