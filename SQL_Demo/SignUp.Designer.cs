﻿namespace SQL_Demo {
    partial class SignUp {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.signUpBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.encryptionTextBox = new System.Windows.Forms.TextBox();
            this.encryptionLabel = new System.Windows.Forms.Label();
            this.writePassword = new System.Windows.Forms.Label();
            this.writeLastNameLabel = new System.Windows.Forms.Label();
            this.writeNameLabel = new System.Windows.Forms.Label();
            this.passAgainTextBox = new System.Windows.Forms.TextBox();
            this.enterPasswordLabel = new System.Windows.Forms.Label();
            this.showCheckBox = new System.Windows.Forms.CheckBox();
            this.IsMD5CheckBox = new System.Windows.Forms.CheckBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(713, 408);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(75, 30);
            this.signUpBtn.TabIndex = 0;
            this.signUpBtn.Text = "SignUp";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(341, 133);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(341, 195);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(341, 261);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 22);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // encryptionTextBox
            // 
            this.encryptionTextBox.Location = new System.Drawing.Point(341, 397);
            this.encryptionTextBox.Name = "encryptionTextBox";
            this.encryptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.encryptionTextBox.TabIndex = 4;
            this.encryptionTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // encryptionLabel
            // 
            this.encryptionLabel.AutoSize = true;
            this.encryptionLabel.Location = new System.Drawing.Point(137, 377);
            this.encryptionLabel.Name = "encryptionLabel";
            this.encryptionLabel.Size = new System.Drawing.Size(538, 17);
            this.encryptionLabel.TabIndex = 5;
            this.encryptionLabel.Text = "Write your encryption (The numbers need to be at the same length of the password)" +
    "";
            // 
            // writePassword
            // 
            this.writePassword.AutoSize = true;
            this.writePassword.Location = new System.Drawing.Point(325, 241);
            this.writePassword.Name = "writePassword";
            this.writePassword.Size = new System.Drawing.Size(137, 17);
            this.writePassword.TabIndex = 6;
            this.writePassword.Text = "Write your password";
            // 
            // writeLastNameLabel
            // 
            this.writeLastNameLabel.AutoSize = true;
            this.writeLastNameLabel.Location = new System.Drawing.Point(324, 175);
            this.writeLastNameLabel.Name = "writeLastNameLabel";
            this.writeLastNameLabel.Size = new System.Drawing.Size(138, 17);
            this.writeLastNameLabel.TabIndex = 7;
            this.writeLastNameLabel.Text = "Write your last name";
            // 
            // writeNameLabel
            // 
            this.writeNameLabel.AutoSize = true;
            this.writeNameLabel.Location = new System.Drawing.Point(338, 113);
            this.writeNameLabel.Name = "writeNameLabel";
            this.writeNameLabel.Size = new System.Drawing.Size(112, 17);
            this.writeNameLabel.TabIndex = 8;
            this.writeNameLabel.Text = "Write your name";
            // 
            // passAgainTextBox
            // 
            this.passAgainTextBox.Location = new System.Drawing.Point(341, 330);
            this.passAgainTextBox.Name = "passAgainTextBox";
            this.passAgainTextBox.Size = new System.Drawing.Size(100, 22);
            this.passAgainTextBox.TabIndex = 9;
            this.passAgainTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // enterPasswordLabel
            // 
            this.enterPasswordLabel.AutoSize = true;
            this.enterPasswordLabel.Location = new System.Drawing.Point(305, 310);
            this.enterPasswordLabel.Name = "enterPasswordLabel";
            this.enterPasswordLabel.Size = new System.Drawing.Size(177, 17);
            this.enterPasswordLabel.TabIndex = 10;
            this.enterPasswordLabel.Text = "Enter again your password";
            // 
            // showCheckBox
            // 
            this.showCheckBox.AutoSize = true;
            this.showCheckBox.Location = new System.Drawing.Point(501, 291);
            this.showCheckBox.Name = "showCheckBox";
            this.showCheckBox.Size = new System.Drawing.Size(64, 21);
            this.showCheckBox.TabIndex = 11;
            this.showCheckBox.Text = "Show";
            this.showCheckBox.UseVisualStyleBackColor = true;
            this.showCheckBox.CheckedChanged += new System.EventHandler(this.showCheckBox_CheckedChanged);
            // 
            // IsMD5CheckBox
            // 
            this.IsMD5CheckBox.AutoSize = true;
            this.IsMD5CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IsMD5CheckBox.Location = new System.Drawing.Point(12, 417);
            this.IsMD5CheckBox.Name = "IsMD5CheckBox";
            this.IsMD5CheckBox.Size = new System.Drawing.Size(279, 24);
            this.IsMD5CheckBox.TabIndex = 12;
            this.IsMD5CheckBox.Text = "I don\'t want to use encryption key";
            this.IsMD5CheckBox.UseVisualStyleBackColor = true;
            this.IsMD5CheckBox.CheckedChanged += new System.EventHandler(this.IsMD5CheckBox_CheckedChanged);
            // 
            // textBox1
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(341, 74);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 22);
            this.usernameTextBox.TabIndex = 13;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // label1
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(324, 54);
            this.usernameLabel.Name = "label1";
            this.usernameLabel.Size = new System.Drawing.Size(140, 17);
            this.usernameLabel.TabIndex = 14;
            this.usernameLabel.Text = "Write your username";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.IsMD5CheckBox);
            this.Controls.Add(this.showCheckBox);
            this.Controls.Add(this.enterPasswordLabel);
            this.Controls.Add(this.passAgainTextBox);
            this.Controls.Add(this.writeNameLabel);
            this.Controls.Add(this.writeLastNameLabel);
            this.Controls.Add(this.writePassword);
            this.Controls.Add(this.encryptionLabel);
            this.Controls.Add(this.encryptionTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.signUpBtn);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox encryptionTextBox;
        private System.Windows.Forms.Label encryptionLabel;
        private System.Windows.Forms.Label writePassword;
        private System.Windows.Forms.Label writeLastNameLabel;
        private System.Windows.Forms.Label writeNameLabel;
        private System.Windows.Forms.TextBox passAgainTextBox;
        private System.Windows.Forms.Label enterPasswordLabel;
        private System.Windows.Forms.CheckBox showCheckBox;
        private System.Windows.Forms.CheckBox IsMD5CheckBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
    }
}

