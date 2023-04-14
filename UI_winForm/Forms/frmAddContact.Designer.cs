namespace UI_winForm.Forms
{
    partial class frmAddContact
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
            نام = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            txtCompany = new System.Windows.Forms.TextBox();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            rtxtDescription = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // نام
            // 
            نام.AutoSize = true;
            نام.Location = new System.Drawing.Point(69, 97);
            نام.Name = "نام";
            نام.Size = new System.Drawing.Size(25, 18);
            نام.TabIndex = 0;
            نام.Text = "نام";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(69, 164);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 18);
            label2.TabIndex = 0;
            label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(69, 221);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 18);
            label3.TabIndex = 0;
            label3.Text = "شرکت";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(69, 291);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 18);
            label4.TabIndex = 0;
            label4.Text = "شماره تلفن";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(69, 359);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(62, 18);
            label5.TabIndex = 0;
            label5.Text = "توضیحات";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(178, 89);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(322, 26);
            txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(178, 156);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(322, 26);
            txtLastName.TabIndex = 1;
            // 
            // txtCompany
            // 
            txtCompany.Location = new System.Drawing.Point(178, 213);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new System.Drawing.Size(322, 26);
            txtCompany.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new System.Drawing.Point(178, 283);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new System.Drawing.Size(322, 26);
            txtPhoneNumber.TabIndex = 1;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new System.Drawing.Point(178, 356);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new System.Drawing.Size(322, 96);
            rtxtDescription.TabIndex = 2;
            rtxtDescription.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Yellow;
            label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            label1.Location = new System.Drawing.Point(219, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(150, 18);
            label1.TabIndex = 3;
            label1.Text = "افزودن مخاطب جدید";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(178, 539);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(128, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ثبت مخاطب جدید";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(363, 539);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(137, 23);
            button2.TabIndex = 4;
            button2.Text = "برگشت";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmAddContact
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.WindowFrame;
            ClientSize = new System.Drawing.Size(528, 647);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(rtxtDescription);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtCompany);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(نام);
            Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmAddContact";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "frmAddContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label نام;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
    }
}