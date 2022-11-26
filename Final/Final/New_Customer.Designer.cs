
namespace SecureDatabase
{
    partial class New_Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.PassTestBox = new System.Windows.Forms.TextBox();
            this.CustomerIDTestBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassTestBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.FnameLabel = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.LnameTextBox = new System.Windows.Forms.TextBox();
            this.FnameTextBox = new System.Windows.Forms.TextBox();
            this.LnameLabel = new System.Windows.Forms.Label();
            this.MobileNumberLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.SuspendLayout();
            // 
            // PassTestBox
            // 
            this.PassTestBox.Location = new System.Drawing.Point(282, 142);
            this.PassTestBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PassTestBox.Name = "PassTestBox";
            this.PassTestBox.PasswordChar = '*';
            this.PassTestBox.Size = new System.Drawing.Size(141, 20);
            this.PassTestBox.TabIndex = 3;
            // 
            // CustomerIDTestBox
            // 
            this.CustomerIDTestBox.Location = new System.Drawing.Point(282, 15);
            this.CustomerIDTestBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerIDTestBox.Name = "CustomerIDTestBox";
            this.CustomerIDTestBox.Size = new System.Drawing.Size(141, 20);
            this.CustomerIDTestBox.TabIndex = 4;
            // 
            // ConfirmPassTestBox
            // 
            this.ConfirmPassTestBox.Location = new System.Drawing.Point(282, 171);
            this.ConfirmPassTestBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmPassTestBox.Name = "ConfirmPassTestBox";
            this.ConfirmPassTestBox.PasswordChar = '*';
            this.ConfirmPassTestBox.Size = new System.Drawing.Size(141, 20);
            this.ConfirmPassTestBox.TabIndex = 5;
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassLabel.Location = new System.Drawing.Point(68, 166);
            this.ConfirmPassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(197, 26);
            this.ConfirmPassLabel.TabIndex = 6;
            this.ConfirmPassLabel.Text = "Confirm Password:";
            // 
            // FnameLabel
            // 
            this.FnameLabel.AutoSize = true;
            this.FnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameLabel.Location = new System.Drawing.Point(68, 38);
            this.FnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FnameLabel.Name = "FnameLabel";
            this.FnameLabel.Size = new System.Drawing.Size(86, 26);
            this.FnameLabel.TabIndex = 7;
            this.FnameLabel.Text = "Fname:";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLabel.Location = new System.Drawing.Point(68, 8);
            this.CustomerIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(156, 24);
            this.CustomerIDLabel.TabIndex = 8;
            this.CustomerIDLabel.Text = "Customer ID:";
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(390, 232);
            this.OKButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(126, 51);
            this.OKButton.TabIndex = 10;
            this.OKButton.Text = "Ok";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(9, 232);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(135, 51);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MobileNumberTextBox
            // 
            this.MobileNumberTextBox.Location = new System.Drawing.Point(282, 111);
            this.MobileNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MobileNumberTextBox.Name = "MobileNumberTextBox";
            this.MobileNumberTextBox.Size = new System.Drawing.Size(141, 20);
            this.MobileNumberTextBox.TabIndex = 12;
            // 
            // LnameTextBox
            // 
            this.LnameTextBox.Location = new System.Drawing.Point(282, 80);
            this.LnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LnameTextBox.Name = "LnameTextBox";
            this.LnameTextBox.Size = new System.Drawing.Size(141, 20);
            this.LnameTextBox.TabIndex = 13;
            // 
            // FnameTextBox
            // 
            this.FnameTextBox.Location = new System.Drawing.Point(282, 46);
            this.FnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FnameTextBox.Name = "FnameTextBox";
            this.FnameTextBox.Size = new System.Drawing.Size(141, 20);
            this.FnameTextBox.TabIndex = 14;
            // 
            // LnameLabel
            // 
            this.LnameLabel.AutoSize = true;
            this.LnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameLabel.Location = new System.Drawing.Point(70, 72);
            this.LnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LnameLabel.Name = "LnameLabel";
            this.LnameLabel.Size = new System.Drawing.Size(85, 26);
            this.LnameLabel.TabIndex = 15;
            this.LnameLabel.Text = "Lname:";
            // 
            // MobileNumberLabel
            // 
            this.MobileNumberLabel.AutoSize = true;
            this.MobileNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNumberLabel.Location = new System.Drawing.Point(68, 102);
            this.MobileNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MobileNumberLabel.Name = "MobileNumberLabel";
            this.MobileNumberLabel.Size = new System.Drawing.Size(166, 26);
            this.MobileNumberLabel.TabIndex = 16;
            this.MobileNumberLabel.Text = "Mobile Number:";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(68, 135);
            this.PassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(114, 26);
            this.PassLabel.TabIndex = 17;
            this.PassLabel.Text = "Password:";
            // 
            // New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.MobileNumberLabel);
            this.Controls.Add(this.LnameLabel);
            this.Controls.Add(this.FnameTextBox);
            this.Controls.Add(this.LnameTextBox);
            this.Controls.Add(this.MobileNumberTextBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.FnameLabel);
            this.Controls.Add(this.ConfirmPassLabel);
            this.Controls.Add(this.ConfirmPassTestBox);
            this.Controls.Add(this.CustomerIDTestBox);
            this.Controls.Add(this.PassTestBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Customer";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassTestBox;
        private System.Windows.Forms.TextBox CustomerIDTestBox;
        private System.Windows.Forms.TextBox ConfirmPassTestBox;
        private System.Windows.Forms.Label ConfirmPassLabel;
        private System.Windows.Forms.Label FnameLabel;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox MobileNumberTextBox;
        private System.Windows.Forms.TextBox LnameTextBox;
        private System.Windows.Forms.TextBox FnameTextBox;
        private System.Windows.Forms.Label LnameLabel;
        private System.Windows.Forms.Label MobileNumberLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.ServiceProcess.ServiceController serviceController1;
    }
}