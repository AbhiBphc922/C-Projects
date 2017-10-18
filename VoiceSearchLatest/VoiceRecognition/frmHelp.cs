using System;
using System.IO;
using System.Windows.Forms;

namespace Voice_PM_Search
{
    public partial class frmHelp : Form
    {   
        /// <summary>
        /// Used to display Instructions to the user.
        /// </summary>
        public frmHelp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Used to load the instructions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHelpLoad(object sender, EventArgs e)
        {
            LoadInfo();
        }

        /// <summary>
        /// It is used to read instructions from a file and display it to the user.
        /// </summary>
        private void LoadInfo()
        {   
            string file = "/VoiceSearch/VoiceRecognition/Resources/Instructions.txt";           
            try
            {
                if (!File.Exists(file))
                {
                    throw new FileNotFoundException();
                }             
                else
                {
                    StreamReader myFile = new StreamReader(file);
                    while (myFile.EndOfStream == false)
                    {
                        lblHelp.Text += myFile.ReadLine() + Environment.NewLine;
                    }
                    myFile.Close();
                }
            }
            catch (Exception fe)
            {
                MessageBox.Show("Could not load instructions","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                ErrorLog.WriteErrorLog("Could not open the file due to " + fe.Message + ", " + "occurred at " + DateTime.Now.ToString());
            }
        }
    }
}
