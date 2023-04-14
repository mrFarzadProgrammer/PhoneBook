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
    public partial class frmDetailContact : Form
    {
        private readonly ContactService contactService;
        private readonly int ContactId;
        public frmDetailContact(int ContactId)
        {
            InitializeComponent();
            contactService = new ContactService();
            this.ContactId = ContactId;
        }

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        private void frmDetailContact_Load(object sender, EventArgs e)
        {
            var contact = contactService.GetContactDetail(ContactId);
            if (contact.IsSuccess == false)
            {
                MessageBox.Show(contact.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            lblId.Text = contact.Data.Id.ToString();
            lblName.Text = contact.Data.Name;
            lblLastName.Text = contact.Data.LastName;
            lblPhoneNumber.Text = contact.Data.PhoneNumber;
            lblCompany.Text = contact.Data.Company;
            lblDescription.Text = contact.Data.Description;
            lblCreateAt.Text = contact.Data.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
