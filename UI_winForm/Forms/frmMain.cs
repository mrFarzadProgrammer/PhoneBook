﻿using BLL.Dto;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_winForm.Forms
{
    public partial class frmMain : Form
    {
        private readonly ContactService contactService;
        public frmMain()
        {
            InitializeComponent();
            contactService = new ContactService();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var listContact = contactService.GetContactLists();
            SettingGridView(listContact);

            this.Cursor = Cursors.Default;
        }

        private void SettingGridView(List<ContactListDto> listContact)
        {
            dataGridView1.DataSource = listContact;
            dataGridView1.Columns[0].HeaderText = "شناسه";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "شماره تلفن";

            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Cursor= Cursors.WaitCursor;
            var listContacts = contactService.SearchContact(txtSearchKey.Text);

            this.SettingGridView(listContacts);
            this.Cursor = Cursors.Default;
        }
    }
}