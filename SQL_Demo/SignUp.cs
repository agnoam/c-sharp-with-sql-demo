using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace SQL_Demo {
    public partial class SignUp : Form {
        private string username = "";
        private string name = "";
        private string lastN = "";
        private string password = "";
        private string passAgain = "";
        private string encrShift = "0";
        private bool useMD5 = false;

        public SignUp() {
            InitializeComponent();

            // Setting the password inputs as dots
            passAgainTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            passwordTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (
                username !=  "" && name != "" && lastN != "" && password != "" && passAgain != "" && encrShift != "0" ||
                username != "" && name != "" && lastN != "" && password != "" && passAgain != "" && useMD5
            ) {
                // Checking if the passwords equal
                if(password == passAgain && encrShift.Length == passAgain.Length) {
                    bool isInserted = SQL_Manager.insertNewUser(
                        new UserRecord(username, name, lastN, EncryptionManger.easyEncryption(password, encrShift))
                    );

                    if(isInserted) {
                      MessageBox.Show("User Inserted successfuly");  
                    } else {
                        MessageBox.Show("This username already exists please choose another");
                    }
                } else {
                    if(password == passAgain && useMD5) {
                        bool isInserted = SQL_Manager.insertNewUser(
                            new UserRecord(username, name, lastN, EncryptionManger.MD5(password), useMD5)
                        );

                        if(isInserted) {
                            MessageBox.Show("User Inserted successfuly");  
                        } else {
                            MessageBox.Show("This username already exists please choose another");
                        }
                    } else {
                        string text = "";
                        if (encrShift.Length != password.Length || !useMD5) {
                            text = "Encryption not at the same length as password";
                        } else {
                            text = "The passwords not equal please type again.";
                        }

                        MessageBox.Show(text);
                    }
                }
            } else {
                MessageBox.Show("Something missing... Please check");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            name = nameTextBox.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            lastN = lastNameTextBox.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {
            password = passwordTextBox.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e) {
            passAgain = passAgainTextBox.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {
            encrShift = encryptionTextBox.Text;
        }

        private void showCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (showCheckBox.Checked) {
                passAgainTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
                passwordTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            } else {
                // Hides Textbox password
                passAgainTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
                passwordTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void IsMD5CheckBox_CheckedChanged(object sender, EventArgs e) {
            if(IsMD5CheckBox.Checked) {
                useMD5 = true;

                encryptionTextBox.Visible = false;
                encryptionLabel.Visible = false;
            } else {
                useMD5 = false;

                encryptionTextBox.Visible = true;
                encryptionLabel.Visible = true;
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e) {
            username = usernameTextBox.Text;
        }
    }
}
