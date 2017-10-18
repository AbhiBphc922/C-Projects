using PM_Search_BLL;
using System;
using System.Windows.Forms;

namespace PM_Search_UI
{
    public partial class frmUpdatePerson : Form
    {
        private PersonBLL person;
        public frmUpdatePerson()
        {
            InitializeComponent();
            person = new PersonBLL();
        }

        private void frmUpdatePerson_Load(object sender, EventArgs e)
        {
            lblNoFieldEmpty.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUpdateFName.Text != string.Empty && txtUpdateLName.Text != string.Empty && cboUpdateSex_.Text != string.Empty && txtUpdatedate.Text != string.Empty && txtUpdateVoterID.Text != string.Empty && txtUpdatePersonID.Text != string.Empty)
            {
                bool updatedPersonDetails = person.PersonUpdated(txtUpdateFName.Text, txtUpdateLName.Text, cboUpdateSex_.Text, txtUpdatedate.Text, txtUpdateVoterID.Text, Int32.Parse(txtUpdatePersonID.Text));
                if (updatedPersonDetails)
                {
                    MessageBox.Show("Person Details Modified!", "DataBase Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Modify Details. Try again!", "DataBase Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                lblNoFieldEmpty.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
