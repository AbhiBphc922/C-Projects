using PM_Search_BLL;
using System;
using System.Windows.Forms;

namespace PM_Search_UI
{
    public partial class frmLogin : Form
    {
        private UserBLL user;
        public frmLogin()
        {
            InitializeComponent();
            user = new UserBLL();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserVO _userVO = new UserVO();
            _userVO = user.SetUserData(txtUserName.Text, txtPassword.Text);
            if (_userVO == null)
            {
                MessageBox.Show("No User Found!. Try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ClearAll();
                txtUserName.Focus();
            }
            else
            {
                this.Hide();
                frmPersonSearch mainForm = new frmPersonSearch();
                mainForm.SetUserProperties(_userVO.AccessLevel);
                mainForm.ShowDialog(); 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearAll()
        {
            txtPassword.Text = string.Empty;
            txtUserName.Text = string.Empty;
        }
    }
}
