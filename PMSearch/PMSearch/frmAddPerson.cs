using PM_Search_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_Search_UI
{
    public partial class frmAddPerson : Form
    {
        private PersonBLL person;
        public frmAddPerson()
        {
            InitializeComponent();
            person = new PersonBLL();
            lblNoFieldEmpty_PersonDetails.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtAddFirstName.Text!=string.Empty && txtAddLastName.Text!=string.Empty && cboAddSex.Text!=string.Empty && txtAddDate.Text!=string.Empty && txtAddVoterId.Text!=string.Empty)
            {
                bool addedPersonDetails = person.PersonAdded(txtAddFirstName.Text, txtAddLastName.Text, cboAddSex.Text, txtAddDate.Text, txtAddVoterId.Text);
                if (addedPersonDetails)
                {
                    MessageBox.Show("Person Details Added!", "DataBase Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Failed to Add Details. Try again!", "DataBase Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                lblNoFieldEmpty_PersonDetails.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearAll()
        {
            txtAddFirstName.Text = string.Empty;
            txtAddLastName.Text = string.Empty;
            cboAddSex.Text = string.Empty;
            txtAddDate.Text = string.Empty;
            txtAddVoterId.Text = string.Empty;
        }

        private void dtpAddDOB_ValueChanged(object sender, EventArgs e)
        {
            txtAddDate.Text = dtpAddDOB.Value.ToShortDateString();
        }

        private void frmAddPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
