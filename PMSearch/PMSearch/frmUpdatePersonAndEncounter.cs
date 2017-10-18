using PM_Search_BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PM_Search_UI
{
    public partial class frmUpdatePersonAndEncounter : Form
    {
        private PersonBLL person;
        private EncounterBLL encounter;
        private List<EncounterVO> encounterList;
        int i = 1;
        public frmUpdatePersonAndEncounter()
        {
            InitializeComponent();
            person = new PersonBLL();
            encounter = new EncounterBLL();
        }

        private void frmUpdatePerson_Load(object sender, EventArgs e)
        {
            lblNoFieldEmpty.Hide();
            encounterList = new List<EncounterVO>();
            encounterList = encounter.SetEncounterDataUsingPersonId(Int32.Parse(txtUpdatePersonId.Text));
            txtUpdateEncounterId.Text = encounterList[0].EncounterID.ToString();
            txtUpdatePhysician.Text = encounterList[0].Physician;
            txtUpdateMedication.Text = encounterList[0].Medication;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUpdateFirstName.Text != string.Empty && txtUpdateLastName.Text != string.Empty && cboUpdateSex.Text != string.Empty && txtUpdateDate.Text != string.Empty && txtUpdateVoterId.Text != string.Empty && txtUpdatePersonId.Text!=string.Empty && txtUpdateEncounterId.Text!=string.Empty && txtUpdateMedication.Text!=string.Empty && txtUpdatePhysician.Text!=string.Empty)
            {
                bool updatedPersonDetails = person.PersonUpdated(txtUpdateFirstName.Text, txtUpdateLastName.Text, cboUpdateSex.Text, txtUpdateDate.Text, txtUpdateVoterId.Text, Int32.Parse(txtUpdatePersonId.Text));
                bool updatedEncounterDetails = encounter.EncounterUpdated(Int32.Parse(txtUpdateEncounterId.Text),txtUpdateMedication.Text,txtUpdatePhysician.Text,Int32.Parse(txtUpdatePersonId.Text));
                if (updatedPersonDetails==true && updatedEncounterDetails==true)
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

        private void dtpUpdateDOB_ValueChanged(object sender, EventArgs e)
        {
            txtUpdateDate.Text = dtpUpdateDOB.Value.ToShortDateString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (i<encounterList.Count)
            {
                txtUpdateEncounterId.Text = encounterList[i].EncounterID.ToString();
                txtUpdatePhysician.Text = encounterList[i].Physician.ToString();
                txtUpdateMedication.Text = encounterList[i].Medication.ToString();
                i++;
            }
        }
    }
}
