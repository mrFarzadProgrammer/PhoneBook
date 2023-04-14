using BLL.Dto;
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
    public partial class frmAddContact : Form
    {
        private readonly ContactService contactService;
        public frmAddContact()
        {
            InitializeComponent();
            contactService = new ContactService();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = contactService.AddNewContact(new AddNewContactDto
            {
                Name = txtName.Text,
                LastName = txtLastName.Text,
                Company = txtCompany.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Description = rtxtDescription.Text,
            });
            if (result.IsSuccess == true)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
