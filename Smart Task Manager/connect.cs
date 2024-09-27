using MySql.Data.MySqlClient;
using System;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "server=localhost;database=smart_task_manager;user=root;password=your_password;";
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            Console.WriteLine("Database connected...");

            // Example: Create a new task
            var command = new MySqlCommand("INSERT INTO tasks (title, description) VALUES ('Sample Task', 'This is a sample task.')", connection);
            command.ExecuteNonQuery();
            Console.WriteLine("Task created.");
        }
    }
}
