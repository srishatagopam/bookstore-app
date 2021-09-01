namespace bookstore_app
{
    partial class menu
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
            this.custButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custButton
            // 
            this.custButton.Location = new System.Drawing.Point(106, 66);
            this.custButton.Name = "custButton";
            this.custButton.Size = new System.Drawing.Size(152, 29);
            this.custButton.TabIndex = 0;
            this.custButton.Text = "Manage Customers";
            this.custButton.UseVisualStyleBackColor = true;
            this.custButton.Click += new System.EventHandler(this.custButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(106, 133);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(152, 29);
            this.bookButton.TabIndex = 1;
            this.bookButton.Text = "Manage Books";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(106, 198);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(152, 29);
            this.orderButton.TabIndex = 2;
            this.orderButton.Text = "Place Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 302);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.custButton);
            this.Name = "menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button custButton;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button orderButton;
    }
}