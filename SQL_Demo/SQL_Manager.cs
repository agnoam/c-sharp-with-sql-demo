
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

public class SQL_Manager {

    private static SqlConnection con;

    private static void initialize() {
        string url = Directory.GetCurrentDirectory() + "\\Database\\demoDatabase.mdf";
        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + url + ";" + 
            " Integrated Security = True; Connect Timeout = 30";
        
        con = new SqlConnection(connectionString);
    }

    public static bool connectToSQL() {
        try {
            initialize();
            con.Open();

            return true;
        } catch(SqlException ex) {
            throw ex;
        }
    }

    public static bool closeConnection() {
        try {
            connectToSQL();

            if(con.State != ConnectionState.Closed) {
                con.Close();

                return true;
            }

            return true;
        } catch (SqlException ex) {
            throw ex;
        }
    }

    public static void insertNewUser(User_Record user) {
        try {
            connectToSQL();

            if(con.State == ConnectionState.Open) {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO CUSTOMERS (Id,Name,LastName,Password)
                    VALUES(" + getLastID() + ", " + user.name + ", " + user.lastName + ", " + user.password + ")");
                cmd.Connection = con;

                cmd.ExecuteNonQuery();

                // Closing SQL connection
                closeConnection();
            }
        } catch(SqlException ex) {
            throw ex;
        }
    }

    private static int getLastID(string table) {
        try {
            connectToSQL();

            if(con.State == ConnectionState.Open) {
                

                // Closing SQL connection
                closeConnection();
            }
        } catch(SqlException ex) {

        }
    }

    public static void selectAll(string table) {

        string query = $"SELECT * FROM {table}";

        // Open connection
        connectToSQL();

        if (con.State == ConnectionState.Open) {
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
    
            while(dataReader.Read()) {
                MessageBox.Show(dataReader["Password"].ToString());
            }

            // Closing the reader
            dataReader.Close();

            // Close the connection to The SQL Database
            closeConnection();
        }
    }
}

public interface User_Record {
    string name { get; set; }
    string lastName { get; set; }
    string password { get; set; }
}