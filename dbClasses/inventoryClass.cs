using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDB.dbClasses
{
    internal class inventoryClass
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? SerialNumber { get; set; }
        public string? Description { get; set; }
        public string? Image {  get; set; }

        public static string connectionFile = @"Data Source=inventory.db";

        public inventoryClass(string? name, string? serialNum, string? desc, string? image)
        {
            Name = name;
            SerialNumber = serialNum;
            Description = desc;
            Image = image;
        }

        public static DataTable Select()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add(@"ID", typeof(string));
            dt.Columns.Add(@"Name", typeof(string));
            dt.Columns.Add(@"SerialNumber", typeof(string));
            dt.Columns.Add(@"Description", typeof(string));
            dt.Columns.Add(@"Image", typeof(string));
            using var connection = new SqliteConnection(connectionFile);
            connection.Open();

            // TODO: Add try/catch

            // run sql command into reader
            using var selectCmd = new SqliteCommand("SELECT * from Inventory;", connection);
            using var reader = selectCmd.ExecuteReader();
            while (reader.Read())
            {
                // read each line into a new row and add to DataTable
                DataRow item = dt.NewRow();
                item[@"ID"] = reader["ID"];
                item[@"Name"] = reader["Name"];
                item[@"SerialNumber"] = reader["SerialNumber"];
                item[@"Description"] = reader["Description"];
                item[@"Image"] = reader[@"Image"];

                dt.Rows.Add(item);
            }

            connection.Close();

            return dt;
        }

        public static bool Insert(inventoryClass item)
        {
            bool isInserted = false;

            using var connection = new SqliteConnection(connectionFile);
            connection.Open();
            // TODO: Add try/catch

            // make command and add parameters 
            using var insertCmd = new SqliteCommand("INSERT INTO Inventory (Name, SerialNumber, Description, Image) " +
                "VALUES (@Name, @SerialNumber, @Description, @Image)", connection);

            if (item.Name != null)
            {
                insertCmd.Parameters.AddWithValue("@Name", item.Name);
            }
            else {insertCmd.Parameters.AddWithValue("@Name", DBNull.Value);}

            if (item.SerialNumber != null)
            {
                insertCmd.Parameters.AddWithValue("@SerialNumber", item.SerialNumber);
            }
            else {insertCmd.Parameters.AddWithValue("@SerialNumber", DBNull.Value);}

            if (item.Description != null)
            {
                insertCmd.Parameters.AddWithValue("@Description", item.Description);
            }
            else {insertCmd.Parameters.AddWithValue("@Description", DBNull.Value);}

            if (item.Image != null)
            {
                insertCmd.Parameters.AddWithValue("@Image", item.Image);
            }
            else {insertCmd.Parameters.AddWithValue("@Image", DBNull.Value);}

            int rowsAdded = insertCmd.ExecuteNonQuery(); // will return 1 (number of rows inserted) if successful

            if (rowsAdded > 0)
            {
                isInserted = true;
            }
            connection.Close();
            return isInserted;
        }

    }
}
