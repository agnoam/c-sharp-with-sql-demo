
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

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
            initialize();
            if(con.State != ConnectionState.Closed) {
                con.Close();

                return true;
            }

            return true;
        }
        catch (SqlException ex) {
            throw ex;
        }
    }

    public static void insert(string query) {

        try {
            initialize();

            if(con.State == ConnectionState.Open) {
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = con;

                cmd.ExecuteNonQuery();

                // Closing SQL connection
                closeConnection();
            }
        } catch(SqlException ex) {
            throw ex;
        }
    }

    //public static List<string>[] selectAll(string tableName) {
      //  string query = $"SELECT * FROM {tableName}";
    //}
}