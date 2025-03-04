Run the Application
Open the project in Visual Studio.
Build the solution (Ctrl + Shift + B).
Run the project (F5).

The API will be available at https://localhost:44361/ (Check Visual Studio IIS Express settings for the correct port).
Postman Collection
1. Import Collection
Open Postman
Click Import > File
Select postman_collection.json (provided in the project folder)

2. Available Endpoints
Users:
GET /users - Retrieves a list of users.
GET /users/{id} - Retrieves a specific user.

Items: (Example Resource)
GET /items - Retrieves a list of items.
POST /items - Creates a new item.
PUT /items/{id} - Updates an existing item.
DELETE /items/{id} - Deletes an item.

Notes:
Ensure the database is running before executing requests.
The project follows MVC 5 with Database First approach.
Use the provided Postman collection to easily test all endpoints.
