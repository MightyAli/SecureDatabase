
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Customer));
            this.PassTestBox = new System.Windows.Forms.TextBox();
            this.EmailTestBox = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // PassTestBox
            // 
            this.PassTestBox.Location = new System.Drawing.Point(376, 175);
            this.PassTestBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassTestBox.MaxLength = 20;
            this.PassTestBox.Name = "PassTestBox";
            this.PassTestBox.PasswordChar = '*';
            this.PassTestBox.Size = new System.Drawing.Size(187, 22);
            this.PassTestBox.TabIndex = 5;
            // 
            // EmailTestBox
            // 
            this.EmailTestBox.Location = new System.Drawing.Point(376, 18);
            this.EmailTestBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTestBox.MaxLength = 50;
            this.EmailTestBox.Name = "EmailTestBox";
            this.EmailTestBox.Size = new System.Drawing.Size(187, 22);
            this.EmailTestBox.TabIndex = 1;
            // 
            // ConfirmPassTestBox
            // 
            this.ConfirmPassTestBox.Location = new System.Drawing.Point(376, 211);
            this.ConfirmPassTestBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmPassTestBox.MaxLength = 20;
            this.ConfirmPassTestBox.Name = "ConfirmPassTestBox";
            this.ConfirmPassTestBox.PasswordChar = '*';
            this.ConfirmPassTestBox.Size = new System.Drawing.Size(187, 22);
            this.ConfirmPassTestBox.TabIndex = 6;
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassLabel.Location = new System.Drawing.Point(91, 204);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(244, 31);
            this.ConfirmPassLabel.TabIndex = 6;
            this.ConfirmPassLabel.Text = "Confirm Password:";
            // 
            // FnameLabel
            // 
            this.FnameLabel.AutoSize = true;
            this.FnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameLabel.Location = new System.Drawing.Point(91, 47);
            this.FnameLabel.Name = "FnameLabel";
            this.FnameLabel.Size = new System.Drawing.Size(106, 31);
            this.FnameLabel.TabIndex = 7;
            this.FnameLabel.Text = "Fname:";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLabel.Location = new System.Drawing.Point(91, 10);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(208, 30);
            this.CustomerIDLabel.TabIndex = 8;
            this.CustomerIDLabel.Text = "Email:";
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(520, 286);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(168, 63);
            this.OKButton.TabIndex = 10;
            this.OKButton.Text = "Ok";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 286);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(180, 63);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MobileNumberTextBox
            // 
            this.MobileNumberTextBox.Location = new System.Drawing.Point(376, 137);
            this.MobileNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MobileNumberTextBox.MaxLength = 50;
            this.MobileNumberTextBox.Name = "MobileNumberTextBox";
            this.MobileNumberTextBox.Size = new System.Drawing.Size(187, 22);
            this.MobileNumberTextBox.TabIndex = 4;
            // 
            // LnameTextBox
            // 
            this.LnameTextBox.Location = new System.Drawing.Point(376, 98);
            this.LnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LnameTextBox.MaxLength = 50;
            this.LnameTextBox.Name = "LnameTextBox";
            this.LnameTextBox.Size = new System.Drawing.Size(187, 22);
            this.LnameTextBox.TabIndex = 3;
            // 
            // FnameTextBox
            // 
            this.FnameTextBox.Location = new System.Drawing.Point(376, 57);
            this.FnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FnameTextBox.MaxLength = 50;
            this.FnameTextBox.Name = "FnameTextBox";
            this.FnameTextBox.Size = new System.Drawing.Size(187, 22);
            this.FnameTextBox.TabIndex = 2;
            // 
            // LnameLabel
            // 
            this.LnameLabel.AutoSize = true;
            this.LnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameLabel.Location = new System.Drawing.Point(91, 87);
            this.LnameLabel.Name = "LnameLabel";
            this.LnameLabel.Size = new System.Drawing.Size(104, 31);
            this.LnameLabel.TabIndex = 15;
            this.LnameLabel.Text = "Lname:";
            // 
            // MobileNumberLabel
            // 
            this.MobileNumberLabel.AutoSize = true;
            this.MobileNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNumberLabel.Location = new System.Drawing.Point(91, 129);
            this.MobileNumberLabel.Name = "MobileNumberLabel";
            this.MobileNumberLabel.Size = new System.Drawing.Size(204, 31);
            this.MobileNumberLabel.TabIndex = 16;
            this.MobileNumberLabel.Text = "Mobile Number:";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(91, 168);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(142, 31);
            this.PassLabel.TabIndex = 17;
            this.PassLabel.Text = "Password:";
            // 
            // New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(711, 360);
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
            this.Controls.Add(this.EmailTestBox);
            this.Controls.Add(this.PassTestBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Customer";
            this.Load += new System.EventHandler(this.New_Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassTestBox;
        private System.Windows.Forms.TextBox EmailTestBox;
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
    }
}