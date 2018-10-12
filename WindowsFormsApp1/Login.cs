﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Login : Form {
        private string name = "";
        private string lastN = "";
        private string password = "";
        private string passAgain = "";
        private string encrShift = "0";

        public Login() {
            InitializeComponent();

            passAgainTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            passwordTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }

        private byte[] encryption(string inputToEncrypt) {
            // Convert the string into a byte[].
            byte[] asciiBytes = Encoding.ASCII.GetBytes(inputToEncrypt);
            return asciiBytes;
        }

        private void button1_Click(object sender, EventArgs e) {
            
            if (name != "" && lastN != "" && password != "" && passAgain != "" && encrShift != "0") {
                // Checking if the passwords equal
                if(password == passAgain && encrShift.Length == passAgain.Length) {
                    byte[] bytesToEncrypt = encryption(password);
                    char[] encryptedPass = new char[bytesToEncrypt.Length];

                    int j = 0;
                    for (int i = 0; i < bytesToEncrypt.Length; i++) {
                        // Encrypting
                        byte byteToCheck = bytesToEncrypt[i];
                        int bit = Convert.ToInt32(byteToCheck);
                        int encryptNumber = (int) Char.GetNumericValue(encrShift[j]);
                        bit += encryptNumber;

                        // Converting the number to char
                        encryptedPass[i] = Convert.ToChar(bit);

                        j++;
                    }

                    MessageBox.Show(new String(encryptedPass));
                } else {
                    string text = "";
                    if (encrShift.Length != password.Length) {
                        text = "Encryption not at the same length as password";
                    } else {
                        text = "The passwords not equal please type again.";
                    }

                    MessageBox.Show(text);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                passAgainTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
                passwordTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            } else {
                // Hides Textbox password
                passAgainTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
                passwordTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }
    }
}
