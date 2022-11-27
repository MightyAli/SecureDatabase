namespace SecureDatabase
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.PassLabel = new System.Windows.Forms.Label();
            this.MobileNumberLabel = new System.Windows.Forms.Label();
            this.LnameLabel = new System.Windows.Forms.Label();
            this.FnameTextBox = new System.Windows.Forms.TextBox();
            this.LnameTextBox = new System.Windows.Forms.TextBox();
            this.MobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.FnameLabel = new System.Windows.Forms.Label();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.ConfirmPassTestBox = new System.Windows.Forms.TextBox();
            this.EmailTestBox = new System.Windows.Forms.TextBox();
            this.PassTestBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(82, 168);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(204, 31);
            this.PassLabel.TabIndex = 31;
            this.PassLabel.Text = "New Password:";
            // 
            // MobileNumberLabel
            // 
            this.MobileNumberLabel.AutoSize = true;
            this.MobileNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNumberLabel.Location = new System.Drawing.Point(82, 128);
            this.MobileNumberLabel.Name = "MobileNumberLabel";
            this.MobileNumberLabel.Size = new System.Drawing.Size(204, 31);
            this.MobileNumberLabel.TabIndex = 30;
            this.MobileNumberLabel.Text = "Mobile Number:";
            // 
            // LnameLabel
            // 
            this.LnameLabel.AutoSize = true;
            this.LnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameLabel.Location = new System.Drawing.Point(82, 86);
            this.LnameLabel.Name = "LnameLabel";
            this.LnameLabel.Size = new System.Drawing.Size(191, 39);
            this.LnameLabel.TabIndex = 29;
            this.LnameLabel.Text = "Last Name:";
            // 
            // FnameTextBox
            // 
            this.FnameTextBox.Location = new System.Drawing.Point(392, 55);
            this.FnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FnameTextBox.MaxLength = 50;
            this.FnameTextBox.Name = "FnameTextBox";
            this.FnameTextBox.Size = new System.Drawing.Size(187, 22);
            this.FnameTextBox.TabIndex = 19;
            // 
            // LnameTextBox
            // 
            this.LnameTextBox.Location = new System.Drawing.Point(392, 95);
            this.LnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LnameTextBox.MaxLength = 50;
            this.LnameTextBox.Name = "LnameTextBox";
            this.LnameTextBox.Size = new System.Drawing.Size(187, 22);
            this.LnameTextBox.TabIndex = 20;
            // 
            // MobileNumberTextBox
            // 
            this.MobileNumberTextBox.Location = new System.Drawing.Point(392, 137);
            this.MobileNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MobileNumberTextBox.MaxLength = 50;
            this.MobileNumberTextBox.Name = "MobileNumberTextBox";
            this.MobileNumberTextBox.Size = new System.Drawing.Size(187, 22);
            this.MobileNumberTextBox.TabIndex = 21;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(23, 286);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(180, 63);
            this.CancelButton.TabIndex = 28;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(463, 286);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(236, 63);
            this.OKButton.TabIndex = 27;
            this.OKButton.Text = "Update";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLabel.Location = new System.Drawing.Point(82, 9);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(208, 30);
            this.CustomerIDLabel.TabIndex = 26;
            this.CustomerIDLabel.Text = "Email:";
            // 
            // FnameLabel
            // 
            this.FnameLabel.AutoSize = true;
            this.FnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameLabel.Location = new System.Drawing.Point(82, 46);
            this.FnameLabel.Name = "FnameLabel";
            this.FnameLabel.Size = new System.Drawing.Size(194, 39);
            this.FnameLabel.TabIndex = 25;
            this.FnameLabel.Text = "First Name:";
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassLabel.Location = new System.Drawing.Point(80, 206);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(306, 31);
            this.ConfirmPassLabel.TabIndex = 23;
            this.ConfirmPassLabel.Text = "Confirm New Password:";
            // 
            // ConfirmPassTestBox
            // 
            this.ConfirmPassTestBox.Location = new System.Drawing.Point(392, 212);
            this.ConfirmPassTestBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmPassTestBox.MaxLength = 20;
            this.ConfirmPassTestBox.Name = "ConfirmPassTestBox";
            this.ConfirmPassTestBox.PasswordChar = '*';
            this.ConfirmPassTestBox.Size = new System.Drawing.Size(187, 22);
            this.ConfirmPassTestBox.TabIndex = 24;
            // 
            // EmailTestBox
            // 
            this.EmailTestBox.Location = new System.Drawing.Point(392, 19);
            this.EmailTestBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTestBox.MaxLength = 50;
            this.EmailTestBox.Name = "EmailTestBox";
            this.EmailTestBox.ReadOnly = true;
            this.EmailTestBox.Size = new System.Drawing.Size(187, 22);
            this.EmailTestBox.TabIndex = 18;
            this.EmailTestBox.TabStop = false;
            // 
            // PassTestBox
            // 
            this.PassTestBox.Location = new System.Drawing.Point(392, 176);
            this.PassTestBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassTestBox.MaxLength = 20;
            this.PassTestBox.Name = "PassTestBox";
            this.PassTestBox.PasswordChar = '*';
            this.PassTestBox.Size = new System.Drawing.Size(187, 22);
            this.PassTestBox.TabIndex = 22;
            // 
            // EditUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.MobileNumberLabel);
            this.Controls.Add(this.LnameLabel);
            this.Controls.Add(this.FnameTextBox);
            this.Controls.Add(this.LnameTextBox);
            this.Controls.Add(this.MobileNumberTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.FnameLabel);
            this.Controls.Add(this.ConfirmPassLabel);
            this.Controls.Add(this.ConfirmPassTestBox);
            this.Controls.Add(this.EmailTestBox);
            this.Controls.Add(this.PassTestBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label MobileNumberLabel;
        private System.Windows.Forms.Label LnameLabel;
        private System.Windows.Forms.TextBox FnameTextBox;
        private System.Windows.Forms.TextBox LnameTextBox;
        private System.Windows.Forms.TextBox MobileNumberTextBox;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label FnameLabel;
        private System.Windows.Forms.Label ConfirmPassLabel;
        private System.Windows.Forms.TextBox ConfirmPassTestBox;
        private System.Windows.Forms.TextBox EmailTestBox;
        private System.Windows.Forms.TextBox PassTestBox;
    }
}