namespace SecureDatabase
{
    partial class RBAC_demo
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
            this.components = new System.ComponentModel.Container();
            this.sales_data_button = new System.Windows.Forms.Button();
            this.marketing_data_button = new System.Windows.Forms.Button();
            this.moviesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesDataSet = new SecureDatabase.MoviesDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sales_data_button
            // 
            this.sales_data_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.sales_data_button.Location = new System.Drawing.Point(54, 11);
            this.sales_data_button.Margin = new System.Windows.Forms.Padding(2);
            this.sales_data_button.Name = "sales_data_button";
            this.sales_data_button.Size = new System.Drawing.Size(183, 69);
            this.sales_data_button.TabIndex = 0;
            this.sales_data_button.Text = "View Sales Data";
            this.sales_data_button.UseVisualStyleBackColor = true;
            this.sales_data_button.Click += new System.EventHandler(this.sales_data_button_Click);
            // 
            // marketing_data_button
            // 
            this.marketing_data_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.marketing_data_button.Location = new System.Drawing.Point(308, 11);
            this.marketing_data_button.Margin = new System.Windows.Forms.Padding(2);
            this.marketing_data_button.Name = "marketing_data_button";
            this.marketing_data_button.Size = new System.Drawing.Size(183, 69);
            this.marketing_data_button.TabIndex = 1;
            this.marketing_data_button.Text = "View Marketing Email List";
            this.marketing_data_button.UseVisualStyleBackColor = true;
            this.marketing_data_button.Click += new System.EventHandler(this.marketing_data_button_Click);
            // 
            // moviesDataSetBindingSource
            // 
            this.moviesDataSetBindingSource.DataSource = this.moviesDataSet;
            this.moviesDataSetBindingSource.Position = 0;
            // 
            // moviesDataSet
            // 
            this.moviesDataSet.DataSetName = "MoviesDataSet";
            this.moviesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 177);
            this.dataGridView1.TabIndex = 2;
            // 
            // RBAC_demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.marketing_data_button);
            this.Controls.Add(this.sales_data_button);
            this.Name = "RBAC_demo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RBAC Demo";
            this.Load += new System.EventHandler(this.RBAC_demo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sales_data_button;
        private System.Windows.Forms.Button marketing_data_button;
        private System.Windows.Forms.BindingSource moviesDataSetBindingSource;
        private MoviesDataSet moviesDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}