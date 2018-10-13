using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SQL_Demo {
    static class Program {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(SQL_Manager.connectToSQL()) {
                Application.Run(new Login());
            } else {
                MessageBox.Show("Cannot access the Database, Please try again later");
            }
        }
    }
}
