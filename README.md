API Rest .NetFramework usable for storing movies in Database.

Technologies used:
ASP.NET
EntityFramework
MySql Workbench 8.0 

Routing Attributes (Annotations)
[ApiController] - Defines the class as an API controller.

[Route] - Defines the base route path for the controller's endpoints.

[HttpPost] - Maps actions to HTTP POST requests (used for creating resources).

[HttpGet] - Maps actions to HTTP GET requests (used for retrieving data).

[HttpPut] - Maps actions to HTTP PUT requests (used for full updates of resources).

[HttpPatch] - Maps actions to HTTP PATCH requests (used for partial updates).

[HttpDelete] - Maps actions to HTTP DELETE requests (used for deleting resources).

Design Patterns and Architecture
Dependency Injection (DI) - Using the constructor to inject dependencies, promoting loose coupling and testability.

DTOs (Data Transfer Objects) - Objects used to transfer data between layers, separating the internal entity model from the external API contract.

Separation of Concerns - Controllers are focused solely on handling HTTP communication.

RESTful API Techniques
Semantic HTTP Verbs - Proper use of POST, GET, PUT, PATCH, and DELETE to indicate action intent.

Pagination - Limiting the amount of data returned in a single response to improve performance.

Full CRUD Operations - Create, Read, Update, and Delete functionality is fully implemented.

Partial Updates - Using PATCH to apply updates to specific fields without requiring the entire resource.

Database Integration
Entity Framework (EF) - An Object-Relational Mapper (ORM) used to communicate with the database.

Configuration via appsettings.json - Runtime and startup settings are managed in an external configuration file.

Local Database - Using a local database for development purposes.

Implemented Best Practices
Creation DTOs - Specific DTOs used for POST operations (input).

Read DTOs - Specific DTOs used for GET operations (output).

Runtime Data Processing - The ability to calculate or include data in DTOs that isn't necessarily stored in the database.

External Configuration - Separating configuration details from the application code.

Application Structure
Controllers - The presentation/API layer handling HTTP requests and responses.

Entities - Domain models representing the application's data structure.

DTOs - Data Transfer Objects for input and output.

Configuration Files - External files (like appsettings.json) for application settings.

Had a good time building it.
