namespace Software1
{
    partial class MainForm
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
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventory1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.Search2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Add1 = new System.Windows.Forms.Button();
            this.Modify1 = new System.Windows.Forms.Button();
            this.Delete1 = new System.Windows.Forms.Button();
            this.Delete2 = new System.Windows.Forms.Button();
            this.Modify2 = new System.Windows.Forms.Button();
            this.Add2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.PartName,
            this.Inventory,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(1, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(592, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // PartID
            // 
            this.PartID.HeaderText = "Part ID";
            this.PartID.MinimumWidth = 6;
            this.PartID.Name = "PartID";
            this.PartID.Width = 125;
            // 
            // PartName
            // 
            this.PartName.HeaderText = "Part Name";
            this.PartName.MinimumWidth = 6;
            this.PartName.Name = "PartName";
            this.PartName.Width = 125;
            // 
            // Inventory
            // 
            this.Inventory.HeaderText = "Inventory";
            this.Inventory.MinimumWidth = 6;
            this.Inventory.Name = "Inventory";
            this.Inventory.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Inventory1,
            this.Price1,
            this.ProductName});
            this.dataGridView2.Location = new System.Drawing.Point(625, 119);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(591, 183);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 125;
            // 
            // Inventory1
            // 
            this.Inventory1.HeaderText = "Inventory";
            this.Inventory1.MinimumWidth = 6;
            this.Inventory1.Name = "Inventory1";
            this.Inventory1.Width = 125;
            // 
            // Price1
            // 
            this.Price1.HeaderText = "Price";
            this.Price1.MinimumWidth = 6;
            this.Price1.Name = "Price1";
            this.Price1.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(620, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Products";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(527, 62);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(67, 30);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Search2
            // 
            this.Search2.Location = new System.Drawing.Point(1149, 62);
            this.Search2.Margin = new System.Windows.Forms.Padding(4);
            this.Search2.Name = "Search2";
            this.Search2.Size = new System.Drawing.Size(67, 30);
            this.Search2.TabIndex = 6;
            this.Search2.Text = "Search";
            this.Search2.UseVisualStyleBackColor = true;
            this.Search2.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(939, 65);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 22);
            this.textBox2.TabIndex = 8;
            // 
            // Add1
            // 
            this.Add1.Location = new System.Drawing.Point(345, 322);
            this.Add1.Margin = new System.Windows.Forms.Padding(4);
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(77, 30);
            this.Add1.TabIndex = 9;
            this.Add1.Text = "Add";
            this.Add1.UseVisualStyleBackColor = true;
            this.Add1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modify1
            // 
            this.Modify1.Location = new System.Drawing.Point(431, 322);
            this.Modify1.Margin = new System.Windows.Forms.Padding(4);
            this.Modify1.Name = "Modify1";
            this.Modify1.Size = new System.Drawing.Size(77, 30);
            this.Modify1.TabIndex = 10;
            this.Modify1.Text = "Modify";
            this.Modify1.UseVisualStyleBackColor = true;
            // 
            // Delete1
            // 
            this.Delete1.Location = new System.Drawing.Point(516, 322);
            this.Delete1.Margin = new System.Windows.Forms.Padding(4);
            this.Delete1.Name = "Delete1";
            this.Delete1.Size = new System.Drawing.Size(77, 30);
            this.Delete1.TabIndex = 11;
            this.Delete1.Text = "Delete";
            this.Delete1.UseVisualStyleBackColor = true;
            // 
            // Delete2
            // 
            this.Delete2.Location = new System.Drawing.Point(1137, 322);
            this.Delete2.Margin = new System.Windows.Forms.Padding(4);
            this.Delete2.Name = "Delete2";
            this.Delete2.Size = new System.Drawing.Size(77, 30);
            this.Delete2.TabIndex = 14;
            this.Delete2.Text = "Delete";
            this.Delete2.UseVisualStyleBackColor = true;
            // 
            // Modify2
            // 
            this.Modify2.Location = new System.Drawing.Point(1052, 322);
            this.Modify2.Margin = new System.Windows.Forms.Padding(4);
            this.Modify2.Name = "Modify2";
            this.Modify2.Size = new System.Drawing.Size(77, 30);
            this.Modify2.TabIndex = 13;
            this.Modify2.Text = "Modify";
            this.Modify2.UseVisualStyleBackColor = true;
            // 
            // Add2
            // 
            this.Add2.Location = new System.Drawing.Point(967, 322);
            this.Add2.Margin = new System.Windows.Forms.Padding(4);
            this.Add2.Name = "Add2";
            this.Add2.Size = new System.Drawing.Size(77, 30);
            this.Add2.TabIndex = 12;
            this.Add2.Text = "Add";
            this.Add2.UseVisualStyleBackColor = true;
            this.Add2.Click += new System.EventHandler(this.Add2_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1137, 407);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(77, 31);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 469);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Delete2);
            this.Controls.Add(this.Modify2);
            this.Controls.Add(this.Add2);
            this.Controls.Add(this.Delete1);
            this.Controls.Add(this.Modify1);
            this.Controls.Add(this.Add1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventory1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Search2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Add1;
        private System.Windows.Forms.Button Modify1;
        private System.Windows.Forms.Button Delete1;
        private System.Windows.Forms.Button Delete2;
        private System.Windows.Forms.Button Modify2;
        private System.Windows.Forms.Button Add2;
        private System.Windows.Forms.Button Exit;
    }
}

