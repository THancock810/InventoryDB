using InventoryDB.dbClasses;
using Microsoft.Data.Sqlite;

namespace InventoryDB
{
    internal static class Program
    {

        static bool checkForUser()
        {

            return true;
        }


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            // Open DB connection, automatically creates DB if doesnt exist
            var connectionFile = @"Data Source=inventory.db";
            using var connection = new SqliteConnection(connectionFile);
            connection.Open();

            // create tables if they dont exist
            using var userTable = new SqliteCommand("CREATE TABLE IF NOT EXISTS User " +
                "(ID INTEGER PRIMARY KEY, Username TEXT NOT NULL UNIQUE, Password TEXT NOT NULL);", connection);
            userTable.ExecuteNonQuery();

            using var mainTable = new SqliteCommand("CREATE TABLE IF NOT EXISTS Inventory " +
                "(ID INTEGER PRIMARY KEY, Name TEXT, SerialNumber TEXT, Description TEXT, Image TEXT);", connection);
            mainTable.ExecuteNonQuery();

            // check if there is a user/pass present in the DB
            using var countUsers = new SqliteCommand("SELECT COUNT(*) FROM User", connection);
            long numUsers = (long)countUsers.ExecuteScalar(); // must be long because query returns 64bit number

            //DEBUG:
            //Console.WriteLine($"The number of rows in the User table is: {numUsers}");

            connection.Close();
            if (numUsers < 1)
            {
                // no users, run FirstLaunch
                Application.Run(new FirstLaunch());
            }
            else
            {
                // there is a user, send to login as normal
                userClass.Select();
                Application.Run(new Login());
            }

        }


    }
}
