using PM_Search_BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PM_Search_UI
{
    public partial class frmAddPersonAndEncounter : Form
    {
        private PersonBLL person;
        private EncounterBLL encounter;
        public frmAddPersonAndEncounter()
        {
            InitializeComponent();
            person = new PersonBLL();
            encounter = new EncounterBLL();
            lblNoFieldEmpty_PersonEncounterForm.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddFName.Text!=string.Empty && txtAddLName.Text!=string.Empty && cboAddsex.Text!=string.Empty && txtAddBDate.Text!=string.Empty && txtAddVoterID.Text!=string.Empty && txtAddPhysicianName.Text != string.Empty && txtAddMedicationNames.Text != string.Empty)
            {
                bool addedPersonDetails = person.PersonAdded(txtAddFName.Text, txtAddLName.Text, cboAddsex.Text, txtAddBDate.Text,txtAddVoterID.Text);
                List<PersonVO> personList = new List<PersonVO>();
                personList = person.SetPersonData(txtAddFName.Text, txtAddLName.Text, cboAddsex.Text, txtAddBDate.Text, txtAddVoterID.Text);
                PersonVO personObject = personList[personList.Count - 1];
                bool addedEncounterDetails = encounter.EncounterAdded(txtAddPhysicianName.Text, txtAddMedicationNames.Text, personObject.PersonID);
                if (addedPersonDetails==true && addedEncounterDetails==true)
                {
                    MessageBox.Show("Details Added!", "DataBase Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Failed to Add Details. Try again!", "DataBase Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                lblNoFieldEmpty_PersonEncounterForm.Show();
            }
        }

        private void ClearAll()
        {
            txtAddFName.Text = string.Empty;
            txtAddLName.Text = string.Empty;
            cboAddsex.Text = string.Empty;
            txtAddBDate.Text = string.Empty;
            txtAddVoterID.Text = string.Empty;
            txtAddPhysicianName.Text = string.Empty;
            txtAddMedicationNames.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpAddDOB_ValueChanged(object sender, EventArgs e)
        {
            txtAddBDate.Text = dtpAddBD.Value.ToShortDateString();
        }
    }
}
