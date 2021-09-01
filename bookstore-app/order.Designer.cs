namespace bookstore_app
{
    partial class orderForm
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
            this.bookComboBox = new System.Windows.Forms.ComboBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.isbnText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalText = new System.Windows.Forms.TextBox();
            this.taxText = new System.Windows.Forms.TextBox();
            this.totalText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addTitle = new System.Windows.Forms.Button();
            this.custComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookComboBox
            // 
            this.bookComboBox.AllowDrop = true;
            this.bookComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookComboBox.FormattingEnabled = true;
            this.bookComboBox.Location = new System.Drawing.Point(60, 94);
            this.bookComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookComboBox.Name = "bookComboBox";
            this.bookComboBox.Size = new System.Drawing.Size(611, 24);
            this.bookComboBox.TabIndex = 0;
            this.bookComboBox.SelectedIndexChanged += new System.EventHandler(this.bookComboBox_SelectedIndexChanged);
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(62, 152);
            this.authorText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(168, 22);
            this.authorText.TabIndex = 1;
            this.authorText.TextChanged += new System.EventHandler(this.authorText_TextChanged);
            // 
            // isbnText
            // 
            this.isbnText.Location = new System.Drawing.Point(505, 152);
            this.isbnText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isbnText.Name = "isbnText";
            this.isbnText.Size = new System.Drawing.Size(168, 22);
            this.isbnText.TabIndex = 2;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(297, 152);
            this.priceText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(143, 22);
            this.priceText.TabIndex = 3;
            // 
            // quantityText
            // 
            this.quantityText.Location = new System.Drawing.Point(297, 205);
            this.quantityText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(143, 22);
            this.quantityText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Order Summary";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleColumn,
            this.priceColumn,
            this.qtyColumn,
            this.totalColumn});
            this.dataGridView1.Location = new System.Drawing.Point(60, 294);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(611, 184);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // titleColumn
            // 
            this.titleColumn.HeaderText = "Title";
            this.titleColumn.MinimumWidth = 8;
            this.titleColumn.Name = "titleColumn";
            this.titleColumn.Width = 150;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.MinimumWidth = 8;
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.Width = 150;
            // 
            // qtyColumn
            // 
            this.qtyColumn.HeaderText = "Quantity";
            this.qtyColumn.MinimumWidth = 8;
            this.qtyColumn.Name = "qtyColumn";
            this.qtyColumn.Width = 150;
            // 
            // totalColumn
            // 
            this.totalColumn.HeaderText = "Line Total";
            this.totalColumn.MinimumWidth = 8;
            this.totalColumn.Name = "totalColumn";
            this.totalColumn.Width = 150;
            // 
            // subtotalText
            // 
            this.subtotalText.Location = new System.Drawing.Point(60, 524);
            this.subtotalText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subtotalText.Name = "subtotalText";
            this.subtotalText.Size = new System.Drawing.Size(168, 22);
            this.subtotalText.TabIndex = 11;
            // 
            // taxText
            // 
            this.taxText.Location = new System.Drawing.Point(283, 524);
            this.taxText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taxText.Name = "taxText";
            this.taxText.Size = new System.Drawing.Size(168, 22);
            this.taxText.TabIndex = 12;
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(503, 524);
            this.totalText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(168, 22);
            this.totalText.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Subtotal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(182, 574);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(127, 26);
            this.confirmButton.TabIndex = 17;
            this.confirmButton.Text = "Confirm Order";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(414, 571);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(127, 30);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel Order";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addTitle
            // 
            this.addTitle.Location = new System.Drawing.Point(329, 241);
            this.addTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTitle.Name = "addTitle";
            this.addTitle.Size = new System.Drawing.Size(78, 23);
            this.addTitle.TabIndex = 19;
            this.addTitle.Text = "Add Title";
            this.addTitle.UseVisualStyleBackColor = true;
            this.addTitle.Click += new System.EventHandler(this.addTitle_Click);
            // 
            // custComboBox
            // 
            this.custComboBox.AllowDrop = true;
            this.custComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custComboBox.FormattingEnabled = true;
            this.custComboBox.Location = new System.Drawing.Point(60, 42);
            this.custComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.custComboBox.Name = "custComboBox";
            this.custComboBox.Size = new System.Drawing.Size(611, 24);
            this.custComboBox.TabIndex = 20;
            this.custComboBox.SelectedIndexChanged += new System.EventHandler(this.custCombobox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Select a title:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Select a customer:";
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 640);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.custComboBox);
            this.Controls.Add(this.addTitle);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.taxText);
            this.Controls.Add(this.subtotalText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.isbnText);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.bookComboBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(22, 54);
            this.Name = "orderForm";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bookComboBox;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.TextBox isbnText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox subtotalText;
        private System.Windows.Forms.TextBox taxText;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalColumn;
        private System.Windows.Forms.ComboBox custComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

