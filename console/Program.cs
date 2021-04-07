using System;
using dbdemo_project;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.CreateConnection();
        }
    }
}