namespace bookstore_app
{
    partial class book
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
            this.backButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.bookComboBox = new System.Windows.Forms.ComboBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.isbnText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(598, 61);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(108, 27);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(598, 113);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(108, 27);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New Book";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(598, 168);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 27);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(598, 223);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(108, 27);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // bookComboBox
            // 
            this.bookComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookComboBox.FormattingEnabled = true;
            this.bookComboBox.Location = new System.Drawing.Point(100, 61);
            this.bookComboBox.Name = "bookComboBox";
            this.bookComboBox.Size = new System.Drawing.Size(453, 24);
            this.bookComboBox.TabIndex = 4;
            this.bookComboBox.SelectedIndexChanged += new System.EventHandler(this.bookComboBox_SelectedIndexChanged);
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(100, 113);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(453, 22);
            this.titleText.TabIndex = 5;
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(100, 168);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(329, 22);
            this.authorText.TabIndex = 6;
            // 
            // isbnText
            // 
            this.isbnText.Location = new System.Drawing.Point(100, 223);
            this.isbnText.Name = "isbnText";
            this.isbnText.Size = new System.Drawing.Size(329, 22);
            this.isbnText.TabIndex = 7;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(100, 276);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(164, 22);
            this.priceText.TabIndex = 8;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(30, 113);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(39, 17);
            this.Author.TabIndex = 9;
            this.Author.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Price:";
            // 
            // book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.isbnText);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.bookComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.backButton);
            this.Name = "book";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox bookComboBox;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.TextBox isbnText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}