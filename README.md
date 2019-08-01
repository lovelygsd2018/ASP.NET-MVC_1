# Core_01
<< RESTful WEB API service using .Net Core 2.1  >>

This application is a RESTful WEB API service using .Net Core 2.1.
The architecture consists of Controllers, Services, Repositories and a Database.
This application also uses Entity Framework Core in order to access the database so that the Context folder is created for
 the DbContext.
-.Net Core, needs to set up the database connection in the appsetting.json and Startup.cs, which means, no need for Web.config.
 In particular, the DbContext, the Repositories, the Interfaces are registered in the Startup.cs for implementing Dependency Injection.
-This application uses an asynchronous operation (async & await pair).
-In each Repository class, DbContext is injected through their constructor.
 The Service classes get the data from the Repositories and map their domain data to DTOs(Data Transfer Object) using ViewModels.
 The Service layer handles and encapsulates the business logic and their methods run asynchronously.
 Since these methods return IActionResult, they can handle errors and results.
-The sample result is the following:
 http://localhost:11111/api/Prices
[{"product":"Product1","price":200.00,"supplier":"Supplier1"},
{"product":"Product1","price":300.00,"supplier":"Supplier2"},
{"product":"Product2","price":101.00,"supplier":"Supplier3"},
{"product":"Product2","price":500.00,"supplier":"Supplier1"}]
