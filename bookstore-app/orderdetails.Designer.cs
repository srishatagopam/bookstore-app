namespace compe561_project1
{
    partial class orderdetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.custText = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.isbnText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.qtyText = new System.Windows.Forms.TextBox();
            this.subtotalText = new System.Windows.Forms.TextBox();
            this.taxText = new System.Windows.Forms.TextBox();
            this.totalText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISBN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Subtotal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tax:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total:";
            // 
            // custText
            // 
            this.custText.Location = new System.Drawing.Point(152, 29);
            this.custText.Name = "custText";
            this.custText.ReadOnly = true;
            this.custText.Size = new System.Drawing.Size(164, 22);
            this.custText.TabIndex = 9;
            this.custText.TextChanged += new System.EventHandler(this.custText_TextChanged);
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(152, 80);
            this.titleText.Name = "titleText";
            this.titleText.ReadOnly = true;
            this.titleText.Size = new System.Drawing.Size(164, 22);
            this.titleText.TabIndex = 10;
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(152, 108);
            this.authorText.Name = "authorText";
            this.authorText.ReadOnly = true;
            this.authorText.Size = new System.Drawing.Size(164, 22);
            this.authorText.TabIndex = 11;
            // 
            // isbnText
            // 
            this.isbnText.Location = new System.Drawing.Point(152, 136);
            this.isbnText.Name = "isbnText";
            this.isbnText.ReadOnly = true;
            this.isbnText.Size = new System.Drawing.Size(164, 22);
            this.isbnText.TabIndex = 12;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(152, 172);
            this.priceText.Name = "priceText";
            this.priceText.ReadOnly = true;
            this.priceText.Size = new System.Drawing.Size(164, 22);
            this.priceText.TabIndex = 13;
            // 
            // qtyText
            // 
            this.qtyText.Location = new System.Drawing.Point(152, 204);
            this.qtyText.Name = "qtyText";
            this.qtyText.ReadOnly = true;
            this.qtyText.Size = new System.Drawing.Size(164, 22);
            this.qtyText.TabIndex = 14;
            // 
            // subtotalText
            // 
            this.subtotalText.Location = new System.Drawing.Point(152, 254);
            this.subtotalText.Name = "subtotalText";
            this.subtotalText.ReadOnly = true;
            this.subtotalText.Size = new System.Drawing.Size(164, 22);
            this.subtotalText.TabIndex = 15;
            // 
            // taxText
            // 
            this.taxText.Location = new System.Drawing.Point(152, 282);
            this.taxText.Name = "taxText";
            this.taxText.ReadOnly = true;
            this.taxText.Size = new System.Drawing.Size(164, 22);
            this.taxText.TabIndex = 16;
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(152, 310);
            this.totalText.Name = "totalText";
            this.totalText.ReadOnly = true;
            this.totalText.Size = new System.Drawing.Size(164, 22);
            this.totalText.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(62, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 29);
            this.label10.TabIndex = 18;
            this.label10.Text = "ORDER CONFIRMED!";
            // 
            // orderdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 410);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.taxText);
            this.Controls.Add(this.subtotalText);
            this.Controls.Add(this.qtyText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.isbnText);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.custText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "orderdetails";
            this.Text = "Order Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox custText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.TextBox isbnText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox qtyText;
        private System.Windows.Forms.TextBox subtotalText;
        private System.Windows.Forms.TextBox taxText;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Label label10;
    }
}