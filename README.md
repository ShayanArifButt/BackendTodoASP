# Todo App - ASP.NET Core Backend

This project is the backend part of the Todo App, built with ASP.NET Core. It provides RESTful API endpoints for managing tasks, which are consumed by the React frontend.

## Prerequisites

- .NET 7.0 SDK
- SQLite (included with .NET SDK)

## Setup

1. **Clone the repository**:

    ```bash
    git clone <repository-url>
    cd /BackendTodoASP/BackendTodoASP
    ```

2. **Restore dependencies**:

    ```bash
    dotnet restore
    ```

3. **Install Entity Framework Core Tools Version 7** (if not already installed):

    ```bash
    dotnet tool install --global dotnet-ef --version 7.0.20
    ```

4. **Run the application**:

    ```bash
    dotnet run
    ```


## Project Structure

- `Controllers/TasksController.cs`: Controller for task-related API endpoints.
- `Data/ApplicationDbContext.cs`: Entity Framework Core database context.
- `DTOs/TaskDto.cs`: Data Transfer Object for tasks.
- `Models/TaskItem.cs`: Task entity model.
- `Repositories/TaskRepository.cs`: Repository for task data access.
- `Services/TaskService.cs`: Service layer for task business logic.

## API Endpoints

The following API endpoints are available:

- `GET /api/tasks`: Fetch all tasks.
- `GET /api/tasks/{id}`: Fetch a task by ID.
- `POST /api/tasks`: Create a new task.
- `PUT /api/tasks/{id}`: Update an existing task.
- `DELETE /api/tasks/{id}`: Delete a task.

