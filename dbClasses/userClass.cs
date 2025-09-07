using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDB.dbClasses
{
    public class userClass
    {
        public string Username {  get; set; }
        public string Password { get; set; }

        public static string connectionFile = @"Data Source=inventory.db";

        public static DataTable Select()
        {
            DataTable dt = new DataTable();
            //dt.Columns.Add(@"ID", typeof(string));
            dt.Columns.Add(@"username", typeof(string));
            dt.Columns.Add(@"password", typeof(string));
            using var connection = new SqliteConnection(connectionFile);
            connection.Open();

            // TODO: Add try/catch

            // run sql command into reader
            using var selectCmd = new SqliteCommand("SELECT * from User;", connection);
            using var reader = selectCmd.ExecuteReader();
            while (reader.Read())
            {
                // read each line into a new row and add to DataTable
                DataRow user = dt.NewRow();
                //user[@"ID"] = reader["ID"];
                user[@"username"] = reader["Username"];
                user["Password"] = reader["Password"];
                dt.Rows.Add(user);
            }

            connection.Close();

            // DEBUG:
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }
            return dt;
        }

        public static bool Insert(userClass user)
        {
            bool isInserted = false;

            using var connection = new SqliteConnection(connectionFile);
            connection.Open();
            // TODO: Add try/catch

            // make command and add parameters 
            using var insertCmd = new SqliteCommand("INSERT INTO User (Username, Password) " +
                "VALUES (@Username, @Password)", connection);
            insertCmd.Parameters.AddWithValue("@Username", user.Username);
            insertCmd.Parameters.AddWithValue("@Password", user.Password);

            int rowsAdded = insertCmd.ExecuteNonQuery(); // will return 1 (number of rows inserted) if successful

            if (rowsAdded > 0)
            {
                isInserted = true;
            }
            connection.Close();
            return isInserted;
        }

        public static bool Update(userClass user)
        {
            bool isUpdated = false;

            using (var connection = new SqliteConnection(connectionFile))
            {
                // TODO: Add try/catch
                using var updateCmd = new SqliteCommand("UPDATE User SET Username=@Username, Password=@Password WHERE ID=1", connection);
                updateCmd.Parameters.AddWithValue("@Username", user.Username);
                updateCmd.Parameters.AddWithValue("@Password", user.Password);

                int rowsUpdated = updateCmd.ExecuteNonQuery(); // will return 1 (number of rows inserted) if successful

                if (rowsUpdated > 0)
                {
                    isUpdated = true;
                }
            }

            return isUpdated;
        }

        public static bool Delete(userClass user)
        {
            bool isDeleted = false;

            using (var connection = new SqliteConnection(connectionFile))
            {
                using var deleteCmd = new SqliteCommand("DELETE FROM User WHERE ID=1", connection);
                
                
                int rowsDeleted = deleteCmd.ExecuteNonQuery();

                if (rowsDeleted > 0)
                {
                    isDeleted = true;
                }
            }

            return isDeleted;
        }
    }
}
