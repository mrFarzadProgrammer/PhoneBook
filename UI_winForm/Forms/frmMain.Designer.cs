﻿namespace UI_winForm.Forms
{
    partial class frmMain
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnSearch = new System.Windows.Forms.Button();
            txtSearchKey = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView1.Location = new System.Drawing.Point(0, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(484, 349);
            dataGridView1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(242, 123);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(230, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "جستجو";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchKey
            // 
            txtSearchKey.Location = new System.Drawing.Point(242, 92);
            txtSearchKey.Name = "txtSearchKey";
            txtSearchKey.Size = new System.Drawing.Size(230, 25);
            txtSearchKey.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(307, 61);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 18);
            label1.TabIndex = 3;
            label1.Text = "جستجو کنید";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(6, 125);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(230, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "حذف مخاطب";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 521);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(txtSearchKey);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmMain";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
    }
}