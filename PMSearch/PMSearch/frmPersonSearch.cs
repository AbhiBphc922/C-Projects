using PM_Search_BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PM_Search_UI
{
    public partial class frmPersonSearch : Form
    {
        private int accessLevel;
        private PersonBLL person;
        private EncounterBLL encounter;
        public frmPersonSearch()
        {
            InitializeComponent();
            person = new PersonBLL();
            encounter = new EncounterBLL();
        }

        private void PersonSearchFormLoad(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientDetailsDataSet.Encounter' table. You can move, or remove it, as needed.
            this.encounterTableAdapter.Fill(this.patientDetailsDataSet.Encounter);
            // TODO: This line of code loads data into the 'patientDetailsDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.patientDetailsDataSet.Person);
        }
        public void SetUserProperties(int access)
        {
            accessLevel = access;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(accessLevel!=2)
            {
                btnAddPerson.Enabled = true;
            }
            grdPerson.DataSource = null;
            grdEncounter.DataSource = null;
            List<PersonVO> _personVO = new List<PersonVO>();
            _personVO = person.SetPersonData(txtFirstName.Text, txtLastName.Text, cboSex.Text, txtDate.Text, txtVoterID.Text);
            DataTable personTable = new DataTable();
            DataTable encounterTable = new DataTable();
            if (_personVO!=null)
            {
                personTable.Columns.Add("PersonID", typeof(int));
                personTable.Columns.Add("First Name", typeof(string));
                personTable.Columns.Add("Last Name", typeof(string));
                personTable.Columns.Add("Sex", typeof(string));
                personTable.Columns.Add("Birth Date", typeof(string));
                personTable.Columns.Add("VoterID", typeof(string));
                encounterTable.Columns.Add("EncounterID", typeof(int));
                encounterTable.Columns.Add("Physician", typeof(string));
                encounterTable.Columns.Add("Medication", typeof(string));
                encounterTable.Columns.Add("PersonID", typeof(int));
                if (txtEncounterID.Text == string.Empty)
                {
                    foreach (PersonVO personObject in _personVO)
                    {
                        List<EncounterVO> _encounterVO = new List<EncounterVO>();
                        //code to fill person table with each object
                        personTable.Rows.Add(personObject.PersonID, personObject.FirstName, personObject.LastName, personObject.Sex, personObject.BirthDate, personObject.VoterID);
                        int personid = personObject.PersonID;
                        _encounterVO = encounter.SetEncounterDataUsingPersonId(personid);
                        if (_encounterVO != null)
                        {
                            foreach (EncounterVO encounterObject in _encounterVO)
                            {
                                //code to fill encounter table
                                encounterTable.Rows.Add(encounterObject.EncounterID, encounterObject.Physician, encounterObject.Medication, encounterObject.PersonID);
                            }
                            grdEncounter.DataSource = encounterTable;
                        }
                    }
                    grdPerson.DataSource = personTable;
                }
                else
                {
                    EncounterVO encounterVO = new EncounterVO();
                    PersonVO personVO = new PersonVO();
                    encounterVO = encounter.SetEncounterDataUsingEncounterId(Int32.Parse(txtEncounterID.Text));
                    if (encounterVO != null)
                    {
                        //code to fill encounter table
                        personVO = person.SetPersonDataUsingPersonId(encounterVO.PersonID);
                        encounterTable.Rows.Add(encounterVO.EncounterID, encounterVO.Physician, encounterVO.Medication, encounterVO.PersonID);
                        personTable.Rows.Add(personVO.PersonID,personVO.FirstName,personVO.LastName,personVO.Sex,personVO.BirthDate,personVO.VoterID);
                        grdEncounter.DataSource = encounterTable;
                        grdPerson.DataSource = personTable;
                    }
                }
            }
            if (personTable.Rows.Count> 0)
            {
                lblNoPersonFound.Hide();
                btnAddEncounter.Enabled = true;
                if(accessLevel!=2)
                {
                    btnOK.Enabled = true;
                }
                if(accessLevel!=3)
                {
                    btnPreview.Enabled = true;
                }
            }
            else
            {
                lblNoPersonFound.Show();
            }

            if (encounterTable.Rows.Count> 0)
            {
                lblNoEncounterFound.Hide();
            }
            else
            {
                lblNoEncounterFound.Show();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void ResetAll()
        {
            txtDate.Text = string.Empty;
            txtEncounterID.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtVoterID.Text = string.Empty;
            cboSex.Text = string.Empty;
            grdEncounter.DataSource = null;
            grdPerson.DataSource = null;
            lblNoEncounterFound.Show();
            lblNoPersonFound.Show();
            btnOK.Enabled = false;
            btnAddEncounter.Enabled = false;
            btnPreview.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(grdEncounter.SelectedRows.Count>0)
            {
                frmUpdatePersonAndEncounter updatePersonAndEncounterForm = new frmUpdatePersonAndEncounter();
                updatePersonAndEncounterForm.txtUpdatePersonId.Text = this.grdPerson.CurrentRow.Cells[0].Value.ToString();
                updatePersonAndEncounterForm.txtUpdateFirstName.Text = this.grdPerson.CurrentRow.Cells[1].Value.ToString();
                updatePersonAndEncounterForm.txtUpdateLastName.Text = this.grdPerson.CurrentRow.Cells[2].Value.ToString();
                updatePersonAndEncounterForm.cboUpdateSex.Text = this.grdPerson.CurrentRow.Cells[3].Value.ToString();
                updatePersonAndEncounterForm.txtUpdateDate.Text = this.grdPerson.CurrentRow.Cells[4].Value.ToString();
                updatePersonAndEncounterForm.txtUpdateVoterId.Text = this.grdPerson.CurrentRow.Cells[5].Value.ToString();
                updatePersonAndEncounterForm.ShowDialog();
            }
            else
            {
                frmUpdatePerson updatePersonForm = new frmUpdatePerson();
                updatePersonForm.txtUpdatePersonID.Text = this.grdPerson.CurrentRow.Cells[0].Value.ToString();
                updatePersonForm.txtUpdateFName.Text = this.grdPerson.CurrentRow.Cells[1].Value.ToString();
                updatePersonForm.txtUpdateLName.Text = this.grdPerson.CurrentRow.Cells[2].Value.ToString();
                updatePersonForm.cboUpdateSex_.Text = this.grdPerson.CurrentRow.Cells[3].Value.ToString();
                updatePersonForm.txtUpdatedate.Text = this.grdPerson.CurrentRow.Cells[4].Value.ToString();
                updatePersonForm.txtUpdateVoterID.Text = this.grdPerson.CurrentRow.Cells[5].Value.ToString();
                updatePersonForm.ShowDialog();
            }
            ResetAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            frmPreview preview = new frmPreview();
            TreeNode nodePerson = new TreeNode("Person");
            nodePerson.Nodes.Add("PersonID - " + this.grdPerson.CurrentRow.Cells[0].Value.ToString());
            nodePerson.Nodes.Add("First Name - " + this.grdPerson.CurrentRow.Cells[1].Value.ToString());
            nodePerson.Nodes.Add("Last Name - " + this.grdPerson.CurrentRow.Cells[2].Value.ToString());
            nodePerson.Nodes.Add("Sex - " + this.grdPerson.CurrentRow.Cells[3].Value.ToString());
            nodePerson.Nodes.Add("Birth Date - " + this.grdPerson.CurrentRow.Cells[4].Value.ToString());
            nodePerson.Nodes.Add("VoterID - " + this.grdPerson.CurrentRow.Cells[5].Value.ToString());
            List<EncounterVO> encounterList = new List<EncounterVO>();
            encounterList = encounter.SetEncounterDataUsingPersonId(Int32.Parse(this.grdPerson.CurrentRow.Cells[0].Value.ToString()));
            if(encounterList==null)
            {
                preview.treeDetails.Nodes.Add(nodePerson);
            }
            else
            {
                TreeNode nodeEncounters = new TreeNode("Encounters");
                int i = 1;
                foreach(EncounterVO encounterVO in encounterList)
                {
                    TreeNode nodeEncounter = new TreeNode("Encounter"+i);
                    nodeEncounter.Nodes.Add("EncounterID - "+encounterVO.EncounterID);
                    nodeEncounter.Nodes.Add("Physician - " + encounterVO.Physician);
                    nodeEncounter.Nodes.Add("Medication - " + encounterVO.Medication);
                    nodeEncounter.Nodes.Add("PersonID - " + encounterVO.PersonID);
                    nodeEncounters.Nodes.Add(nodeEncounter);
                    i++;
                }
                preview.treeDetails.Nodes.Add(nodePerson);
                preview.treeDetails.Nodes.Add(nodeEncounters);
            }
            preview.ShowDialog();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Do you want to add Encounter details as well?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                frmAddPerson addPersonForm = new frmAddPerson();
                addPersonForm.ShowDialog();
            }
            else
            {
                frmAddPersonAndEncounter addPersonEncounterForm = new frmAddPersonAndEncounter();
                addPersonEncounterForm.ShowDialog();
            }
            ResetAll();
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            txtDate.Text = dtpDOB.Value.ToShortDateString();
        }

        private void btnAddEncounter_Click(object sender, EventArgs e)
        {
            frmAddEncounter addEncounterForm = new frmAddEncounter();
            addEncounterForm.txtAddPersonId.Text = this.grdPerson.CurrentRow.Cells[0].Value.ToString();
            addEncounterForm.txtFName.Text = this.grdPerson.CurrentRow.Cells[1].Value.ToString();
            addEncounterForm.txtLName.Text = this.grdPerson.CurrentRow.Cells[2].Value.ToString();
            addEncounterForm.cboAddSex.Text = this.grdPerson.CurrentRow.Cells[3].Value.ToString();
            addEncounterForm.txtBDate.Text = this.grdPerson.CurrentRow.Cells[4].Value.ToString();
            addEncounterForm.txtVoterId.Text = this.grdPerson.CurrentRow.Cells[5].Value.ToString();
            addEncounterForm.ShowDialog();
            ResetAll();
        }

        private void grdPerson_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            int pid = Int32.Parse(e.Row.Cells[0].Value.ToString());
            foreach(DataGridViewRow row in grdEncounter.Rows)
            {
                if (pid == Int32.Parse(row.Cells[3].Value.ToString()))
                {
                    row.Selected = true;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void frmPersonSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
