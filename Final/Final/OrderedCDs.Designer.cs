
namespace SecureDatabase
{
    partial class OrderedCDs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CDIDTextBox = new System.Windows.Forms.TextBox();
            this.CDidLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.OrderedQuantityTextBox = new System.Windows.Forms.TextBox();
            this.OrderedQuantityLabel = new System.Windows.Forms.Label();
            this.MovieNameTextBox = new System.Windows.Forms.TextBox();
            this.OrderDateTextBox = new System.Windows.Forms.TextBox();
            this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.MovieNameLabel = new System.Windows.Forms.Label();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.AddToMyCartButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(956, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // CDIDTextBox
            // 
            this.CDIDTextBox.Location = new System.Drawing.Point(130, 30);
            this.CDIDTextBox.Name = "CDIDTextBox";
            this.CDIDTextBox.Size = new System.Drawing.Size(205, 26);
            this.CDIDTextBox.TabIndex = 2;
            // 
            // CDidLabel
            // 
            this.CDidLabel.AutoSize = true;
            this.CDidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDidLabel.Location = new System.Drawing.Point(15, 19);
            this.CDidLabel.Name = "CDidLabel";
            this.CDidLabel.Size = new System.Drawing.Size(79, 29);
            this.CDidLabel.TabIndex = 4;
            this.CDidLabel.Text = "CD id:";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(394, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(158, 53);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search:";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(22, 476);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(301, 53);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "<<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(26, 99);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(106, 29);
            this.QuantityLabel.TabIndex = 13;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(138, 109);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(187, 26);
            this.QuantityTextBox.TabIndex = 14;
            // 
            // OrderedQuantityTextBox
            // 
            this.OrderedQuantityTextBox.Location = new System.Drawing.Point(379, 109);
            this.OrderedQuantityTextBox.Name = "OrderedQuantityTextBox";
            this.OrderedQuantityTextBox.Size = new System.Drawing.Size(173, 26);
            this.OrderedQuantityTextBox.TabIndex = 15;
            // 
            // OrderedQuantityLabel
            // 
            this.OrderedQuantityLabel.AutoSize = true;
            this.OrderedQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderedQuantityLabel.Location = new System.Drawing.Point(357, 77);
            this.OrderedQuantityLabel.Name = "OrderedQuantityLabel";
            this.OrderedQuantityLabel.Size = new System.Drawing.Size(210, 29);
            this.OrderedQuantityLabel.TabIndex = 16;
            this.OrderedQuantityLabel.Text = "Ordered_Quantity:";
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Location = new System.Drawing.Point(595, 47);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(191, 26);
            this.MovieNameTextBox.TabIndex = 17;
            // 
            // OrderDateTextBox
            // 
            this.OrderDateTextBox.Location = new System.Drawing.Point(603, 109);
            this.OrderDateTextBox.Name = "OrderDateTextBox";
            this.OrderDateTextBox.Size = new System.Drawing.Size(183, 26);
            this.OrderDateTextBox.TabIndex = 18;
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.Location = new System.Drawing.Point(815, 47);
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.Size = new System.Drawing.Size(183, 26);
            this.UnitPriceTextBox.TabIndex = 20;
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.AutoSize = true;
            this.MovieNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieNameLabel.Location = new System.Drawing.Point(590, 15);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(162, 29);
            this.MovieNameLabel.TabIndex = 21;
            this.MovieNameLabel.Text = "Movie_Name:";
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceLabel.Location = new System.Drawing.Point(802, 15);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(130, 29);
            this.UnitPriceLabel.TabIndex = 22;
            this.UnitPriceLabel.Text = "Unit_Price:";
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDateLabel.Location = new System.Drawing.Point(590, 76);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(145, 29);
            this.OrderDateLabel.TabIndex = 23;
            this.OrderDateLabel.Text = "Order_Date:";
            // 
            // AddToMyCartButton
            // 
            this.AddToMyCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToMyCartButton.Location = new System.Drawing.Point(815, 88);
            this.AddToMyCartButton.Name = "AddToMyCartButton";
            this.AddToMyCartButton.Size = new System.Drawing.Size(180, 53);
            this.AddToMyCartButton.TabIndex = 24;
            this.AddToMyCartButton.Text = "Add to my cart:";
            this.AddToMyCartButton.UseVisualStyleBackColor = true;
            this.AddToMyCartButton.Click += new System.EventHandler(this.AddToMyCartButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(795, 529);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(173, 26);
            this.textBox1.TabIndex = 25;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLabel.Location = new System.Drawing.Point(691, 476);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(136, 29);
            this.TotalPriceLabel.TabIndex = 26;
            this.TotalPriceLabel.Text = "Total Price:";
            // 
            // OrderedCDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1024, 579);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddToMyCartButton);
            this.Controls.Add(this.OrderDateLabel);
            this.Controls.Add(this.UnitPriceLabel);
            this.Controls.Add(this.MovieNameLabel);
            this.Controls.Add(this.UnitPriceTextBox);
            this.Controls.Add(this.OrderDateTextBox);
            this.Controls.Add(this.MovieNameTextBox);
            this.Controls.Add(this.OrderedQuantityLabel);
            this.Controls.Add(this.OrderedQuantityTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CDidLabel);
            this.Controls.Add(this.CDIDTextBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderedCDs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox CDIDTextBox;
        private System.Windows.Forms.Label CDidLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox OrderedQuantityTextBox;
        private System.Windows.Forms.Label OrderedQuantityLabel;
        private System.Windows.Forms.TextBox MovieNameTextBox;
        private System.Windows.Forms.TextBox OrderDateTextBox;
        private System.Windows.Forms.TextBox UnitPriceTextBox;
        private System.Windows.Forms.Label MovieNameLabel;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.Button AddToMyCartButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TotalPriceLabel;
    }
}