namespace SecureDatabase
{
    partial class RBAC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RBAC));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SalesDataButton = new System.Windows.Forms.Button();
            this.MarketingDataButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(873, 285);
            this.dataGridView1.TabIndex = 2;
            // 
            // SalesDataButton
            // 
            this.SalesDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDataButton.Location = new System.Drawing.Point(90, 32);
            this.SalesDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalesDataButton.Name = "SalesDataButton";
            this.SalesDataButton.Size = new System.Drawing.Size(247, 53);
            this.SalesDataButton.TabIndex = 30;
            this.SalesDataButton.Text = "View Sales Data";
            this.SalesDataButton.UseVisualStyleBackColor = true;
            this.SalesDataButton.Click += new System.EventHandler(this.SalesDataButton_Click);
            // 
            // MarketingDataButton
            // 
            this.MarketingDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarketingDataButton.Location = new System.Drawing.Point(549, 32);
            this.MarketingDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MarketingDataButton.Name = "MarketingDataButton";
            this.MarketingDataButton.Size = new System.Drawing.Size(247, 53);
            this.MarketingDataButton.TabIndex = 31;
            this.MarketingDataButton.Text = "View Marketing Data";
            this.MarketingDataButton.UseVisualStyleBackColor = true;
            this.MarketingDataButton.Click += new System.EventHandler(this.MarketingDataButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(90, 408);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(247, 53);
            this.BackButton.TabIndex = 32;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RBAC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(913, 472);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MarketingDataButton);
            this.Controls.Add(this.SalesDataButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RBAC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RBAC";
            this.Load += new System.EventHandler(this.RBAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SalesDataButton;
        private System.Windows.Forms.Button MarketingDataButton;
        private System.Windows.Forms.Button BackButton;
    }
}