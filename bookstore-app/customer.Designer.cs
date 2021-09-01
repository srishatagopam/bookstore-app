namespace compe561_project1
{
    partial class custForm
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
            this.custComboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.newCustButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.firstText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stateText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.zipText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // custComboBox
            // 
            this.custComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custComboBox.FormattingEnabled = true;
            this.custComboBox.Location = new System.Drawing.Point(114, 44);
            this.custComboBox.Name = "custComboBox";
            this.custComboBox.Size = new System.Drawing.Size(545, 24);
            this.custComboBox.TabIndex = 0;
            this.custComboBox.SelectedIndexChanged += new System.EventHandler(this.custComboBox_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(719, 43);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(109, 24);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newCustButton
            // 
            this.newCustButton.Location = new System.Drawing.Point(719, 88);
            this.newCustButton.Name = "newCustButton";
            this.newCustButton.Size = new System.Drawing.Size(109, 24);
            this.newCustButton.TabIndex = 2;
            this.newCustButton.Text = "New Customer";
            this.newCustButton.UseVisualStyleBackColor = true;
            this.newCustButton.Click += new System.EventHandler(this.newCustButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(719, 134);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(109, 24);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(719, 178);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(109, 24);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // firstText
            // 
            this.firstText.Location = new System.Drawing.Point(114, 86);
            this.firstText.Name = "firstText";
            this.firstText.Size = new System.Drawing.Size(207, 22);
            this.firstText.TabIndex = 5;
            this.firstText.TextChanged += new System.EventHandler(this.firstText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lastText
            // 
            this.lastText.Location = new System.Drawing.Point(448, 88);
            this.lastText.Name = "lastText";
            this.lastText.Size = new System.Drawing.Size(211, 22);
            this.lastText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Address";
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(114, 134);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(545, 22);
            this.addressText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "City";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(114, 175);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(207, 22);
            this.cityText.TabIndex = 11;
            this.cityText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "State";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(388, 178);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(54, 22);
            this.stateText.TabIndex = 13;
            this.stateText.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Zip";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // zipText
            // 
            this.zipText.Location = new System.Drawing.Point(496, 178);
            this.zipText.Name = "zipText";
            this.zipText.Size = new System.Drawing.Size(163, 22);
            this.zipText.TabIndex = 15;
            this.zipText.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Phone";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(114, 219);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(207, 22);
            this.phoneText.TabIndex = 17;
            this.phoneText.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(114, 267);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(328, 22);
            this.emailText.TabIndex = 19;
            this.emailText.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // custForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 338);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zipText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstText);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newCustButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.custComboBox);
            this.Name = "custForm";
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.custForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.custForm_FormClosed);
            this.Load += new System.EventHandler(this.custForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox custComboBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button newCustButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox firstText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox zipText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emailText;
    }
}