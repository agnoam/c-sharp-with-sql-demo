using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL_Demo {
    public partial class Login: Form {

        string username = "";
        string password = "";
        string encryptionKey = "";

        public Login() {
            InitializeComponent();
            passwordTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }

        private void loginBtn_Click(object sender, EventArgs e) {
            if(username != "" && password != "") {
                AuthObject[] auths = SQL_Manager.getAuthObjectByUsername(username);

                if (auths.Length > 0) {
                    // Check if this pair of username and password are correct
                    for(int i = 0; i < auths.Length; i++) {
                        if(auths[i].username == username) {

                            string encryptedPassword;

                            if (auths[i].isMD5) {
                                encryptedPassword = EncryptionManger.MD5(password);
                            } else {
                                encryptedPassword = EncryptionManger.easyEncryption(password, encryptionKey);
                            }

                            if(encryptedPassword == auths[i].encryptedPass) {
                                MessageBox.Show("Congragulations! you are connected to Demo_SQL");
                            } else {
                                MessageBox.Show("The username or the password are incorrect");
                            }
                        }
                    }
                } else {
                    MessageBox.Show("The username or the password are incorrect");
                }
            } else {
                MessageBox.Show("Please enter the required fields");
            }
        }

        private void signUpLabel_Click(object sender, EventArgs e) {
            using(SignUp signUpForm = new SignUp()) {
                Hide();
                signUpForm.ShowDialog();
                Environment.Exit(0);
                Application.Exit();
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e) {
            username = usernameTextBox.Text;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e) {
            password = passwordTextBox.Text;
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (showPasswordCheckBox.Checked) {
                // Shows the password
                passwordTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            } else {
                // Hides Textbox password
                passwordTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void encryptionKeyTextBox_TextChanged(object sender, EventArgs e) {
            encryptionKey = encryptionKeyTextBox.Text;
        }
    }
}