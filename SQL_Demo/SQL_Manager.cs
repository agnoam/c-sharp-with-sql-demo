
using SQL_Demo;
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

    public static void insertNewUser(UserRecord user) {
        try {
            connectToSQL();

            if(con.State == ConnectionState.Open) {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Users (Username, FirstName, LastName, Password, IsMD5)
                    VALUES('" + user.username + "', '" + user.name + "', '" + user.lastName + "', '" + user.password + "', "
                    + (user.isMD5 ? 1 : 0) + ")");
                cmd.Connection = con;

                cmd.ExecuteNonQuery();

                MessageBox.Show("User Inserted successfuly");

                // Closing SQL connection
                closeConnection();
            }
        } catch(SqlException ex) {
            throw ex;
        }
    }

    public static AuthObject[] getAuthObjectByUsername(string username) {
        string query = $"SELECT Password, IsMD5 FROM Users WHERE Username = {username}";
        List<AuthObject> authObjects = new List<AuthObject>();

        try {
            connectToSQL();

            if (con.State == ConnectionState.Open) {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read()) {
                    authObjects.Add(new AuthObject(
                        dataReader["Username"].ToString(), 
                        dataReader["Password"].ToString(),
                        EncryptionManger.boolFromString(dataReader["IsMD5"].ToString())
                    ));
                }

                // Closing the reader
                dataReader.Close();

                // Close the connection to The SQL Database
                closeConnection();
            }

            return authObjects.ToArray();
        } catch (SqlException ex) {
            throw ex;
        }
    }

    public static List<string> selectAll(string table, string column) {

        string query = $"SELECT * FROM {table}";
        List<string> listToReturn = new List<string>();

        // Open connection
        connectToSQL();

        if (con.State == ConnectionState.Open) {
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
    
            while(dataReader.Read()) {
                listToReturn.Add(dataReader[column].ToString());
            }

            // Closing the reader
            dataReader.Close();

            // Close the connection to The SQL Database
            closeConnection();
        }

        return listToReturn;
    }
}

public class UserRecord {
    public string username { get; set; }
    public string name { get; set; }
    public string lastName { get; set; }
    public string password { get; set; }
    public bool isMD5 { get; set; }

    public UserRecord(string username_c, string name_c, string lastName_c, string password_c) {
        username = username_c;
        name = name_c;
        lastName = lastName_c;
        password = password_c;
        isMD5 = false;
    }

    public UserRecord(string username_c, string name_c, string lastName_c, string password_c, bool isMD5_c) {
        username = username_c;
        name = name_c;
        lastName = lastName_c;
        password = password_c;
        isMD5 = isMD5_c;
    }
}

public class AuthObject {
    public string username { get; set; }
    public string encryptedPass { get; set; }
    public bool isMD5 { get; set; }

    public AuthObject(string username_c, string encryptedPass_c, bool isMD5_c) {
        username = username_c;
        encryptedPass = encryptedPass_c;
        isMD5 = isMD5_c;
    }
}