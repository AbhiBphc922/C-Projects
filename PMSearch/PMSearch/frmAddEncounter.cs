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
    public partial class frmAddEncounter : Form
    {
        private EncounterBLL encounter;
        public frmAddEncounter()
        {
            InitializeComponent();
            encounter = new EncounterBLL();
            lblNoFieldEmpty_EncounterForm.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void ClearAll()
        {
            txtAddPhysician.Text = string.Empty;
            txtAddMedication.Text = string.Empty;
        }

        private void frmAddEncounter_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtAddPhysician.Text != string.Empty && txtAddMedication.Text != string.Empty)
            {
                bool addedEncounterDetails = encounter.EncounterAdded(txtAddPhysician.Text, txtAddMedication.Text, Int32.Parse(txtAddPersonId.Text));
                if (addedEncounterDetails)
                {
                    MessageBox.Show("Encounter Details Added!", "DataBase Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Failed to Add Details. Try again!", "DataBase Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                lblNoFieldEmpty_EncounterForm.Show();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
