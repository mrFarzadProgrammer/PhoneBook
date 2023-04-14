namespace UI_winForm.Forms
{
    partial class frmEditContact
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
            label1 = new System.Windows.Forms.Label();
            rtxtDescription = new System.Windows.Forms.RichTextBox();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            txtCompany = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            نام = new System.Windows.Forms.Label();
            btnSaveEdit = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Yellow;
            label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            label1.Location = new System.Drawing.Point(205, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 18);
            label1.TabIndex = 15;
            label1.Text = "ویرایش مخاطب";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new System.Drawing.Point(164, 346);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new System.Drawing.Size(322, 96);
            rtxtDescription.TabIndex = 14;
            rtxtDescription.Text = "";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new System.Drawing.Point(164, 273);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new System.Drawing.Size(322, 26);
            txtPhoneNumber.TabIndex = 10;
            // 
            // txtCompany
            // 
            txtCompany.Location = new System.Drawing.Point(164, 203);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new System.Drawing.Size(322, 26);
            txtCompany.TabIndex = 11;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(164, 146);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(322, 26);
            txtLastName.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(164, 79);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(322, 26);
            txtName.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(55, 349);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(71, 18);
            label5.TabIndex = 5;
            label5.Text = "توضیحات";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(55, 281);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(91, 18);
            label4.TabIndex = 6;
            label4.Text = "شماره تلفن";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(55, 211);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 18);
            label3.TabIndex = 7;
            label3.Text = "شرکت";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(55, 154);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 18);
            label2.TabIndex = 8;
            label2.Text = "نام خانوادگی";
            // 
            // نام
            // 
            نام.AutoSize = true;
            نام.Location = new System.Drawing.Point(55, 87);
            نام.Name = "نام";
            نام.Size = new System.Drawing.Size(28, 18);
            نام.TabIndex = 9;
            نام.Text = "نام";
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.Location = new System.Drawing.Point(164, 511);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new System.Drawing.Size(157, 23);
            btnSaveEdit.TabIndex = 16;
            btnSaveEdit.Text = "ثبت تغییرات";
            btnSaveEdit.UseVisualStyleBackColor = true;
            btnSaveEdit.Click += btnSaveEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(337, 511);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(149, 23);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "برگشت";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // frmEditContact
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.WindowFrame;
            ClientSize = new System.Drawing.Size(532, 575);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveEdit);
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
            Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmEditContact";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "frmEdit";
            Load += frmEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label نام;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnCancel;
    }
}