
## Introduction
The **Smart Task Manager API** is a RESTful API built to manage tasks and includes AI-driven features for task suggestions and automation. This API supports task CRUD operations, due date predictions, recurring tasks, and reminder notifications.

## Features
- Create, retrieve, update, and delete tasks.
- Smart AI task title/description suggestions.
- Predict optimal due dates based on historical data.
- Set and automate recurring tasks.
- Notification reminders for tasks due soon.

## Requirements
- .NET SDK (for C# projects)
- MySQL
- Node.js and npm (for front-end or specific automation features)
- Git
- Visual Studio or Visual Studio Code (recommended for development)

Set Up the Environment
Create a .env file in the project root and add the following environment variables:

DB_HOST=localhost
DB_USER=root
DB_PASSWORD=your_password
DB_NAME=smart_task_manager
OPENAI_API_KEY=your_openai_api_key

For .NET (C# projects):

dotnet restore

MySQL database:

sql

CREATE DATABASE smart_task_manager;

USE smart_task_manager;

CREATE TABLE tasks (
    id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    description TEXT,
    due_date DATE,
    completed BOOLEAN DEFAULT FALSE,
    priority ENUM('low', 'medium', 'high') DEFAULT 'low',
    recurrence ENUM('daily', 'weekly', 'monthly') DEFAULT NULL
);

Run the Application
To start the API:


dotnet run
For Node.js (if app
