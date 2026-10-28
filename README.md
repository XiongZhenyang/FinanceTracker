Personal Finance Tracker

Description
This is a backend REST API for a Personal Finance Tracker. 
It allows users to create accounts, classify income and expenses, record operations, and view statistics. 
The project is built with C# and ASP.NET Core, using Entity Framework Core and PostgreSQL.

Features
Account management
Category management
Operations with automatic balance updates
Statistics calculation

API Endpoints
Accounts API
GET /api/accounts - Retrieve all accounts
POST /api/accounts - Create a new account

Categories API
GET /api/categories - Retrieve all categories
POST /api/categories - Create a new category

Operations API
GET /api/operations - Retrieve all operations
POST /api/operations - Create a new operation
DELETE /api/operations/{id} - Delete an operation and rollback balance

Statistics API
GET /api/statistics - Get total income, expense, and net balance

How to run
1. Update the connection string in appsettings.json.
2. Run the following commands in the terminal:
dotnet build
dotnet run --project src/FinanceTracker.Api

Documentation
Detailed technical documentation and project planning can be found in the Kreo Knowledge Base.

Author
Xiong Zhenyang

Version
v1.0.0 - Final Release