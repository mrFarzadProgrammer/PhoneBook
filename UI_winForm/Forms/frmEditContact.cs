using BLL.Services;
using System;
using System.Windows.Forms;

namespace UI_winForm.Forms
{
    public partial class frmEditContact : Form
    {
        private readonly ContactService contactService;
        private readonly int ContactId;
        public frmEditContact(int contactId)
        {
            InitializeComponent();
            ContactId = contactId;
            contactService = new ContactService();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            var contact = contactService.GetContactDetail(ContactId);
            if (contact.IsSuccess == false)
            {
                MessageBox.Show(contact.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtName.Text = contact.Data.Name;
                txtLastName.Text = contact.Data.LastName;
                txtPhoneNumber.Text = contact.Data.PhoneNumber;
                txtCompany.Text = contact.Data.Company;
                rtxtDescription.Text = contact.Data.Description;
            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            var result = contactService.EditContact(new BLL.Dto.EditContactDto
            {
                Id = ContactId,
                Name = txtName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Company = txtCompany.Text,
                Description = rtxtDescription.Text,
            });
            if (result.IsSuccess)
            {
                MessageBox.Show(result.Message,"",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
