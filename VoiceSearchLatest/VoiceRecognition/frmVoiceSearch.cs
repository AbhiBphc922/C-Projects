using System;
using System.Speech.Recognition;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Voice_PM_Search
{
    /// <summary>
    /// This form is used to search and add names to Patient database.
    /// </summary>
    public partial class frmVoiceSearch : Form
    {   
        internal InitializeRecorder recordedSpeech;
        internal SqlConnection dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VoiceSearch\VoiceRecognition\Patient_Details.mdf;Integrated Security=True");

        /// <summary>
        /// To Initialize the Form
        /// </summary>
        public frmVoiceSearch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Used to perform any operations while loading the form.
        /// Here it is used to setup the Speech Recognition Engine
        /// </summary>
        /// <param name="sender">Contains a Reference to the event frmSpeechRecognitionLoad</param>
        /// <param name="e">Contains Form Load Data</param>
        private void frmVoiceSearchLoad(object sender, EventArgs e)
        {
            //Calls InitializeRecorder constructor which loads the grammar into Speech Recognition Engine
            recordedSpeech = new InitializeRecorder();
            //Checks database connection and then calls createGrammar method.
            if (CheckDBConnection(dbConnection))
            {
                recordedSpeech.CreateGrammar(dbConnection);
            }
            //Sets default input to Microphone
            recordedSpeech.recognizer.SetInputToDefaultAudioDevice();
            cmdStart.Enabled = true;
            cmdStop.Enabled = false;
            txtNameSearch.Enabled = false;
            txtNameSearch.MaxLength = 20;
            dgdDisplayResult.Hide();
            lblNoResult.Hide();
        }

        /// <summary>
        /// It is called when SpeechRecognitionEngine recognizes the input
        /// </summary>
        /// <param name="sender">Contains a Reference to the event SpeechRecognition</param>
        /// <param name="e">Contains Recognized text</param>
        private void SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            RecognizedText(e.Result.Text.ToString());          
        }

        /// <summary>
        /// This method is used to perform operations on the recognized text
        /// </summary>
        /// <param name="searchName">Contains the name in search box</param>
        private void RecognizedText(string searchName)
        {
            //Display recognized text on the text box depending on the recognized word
            switch (searchName.ToLower())
            {
                case "exit"://Applications Exits
                    AppExit();
                    break;
                case "type"://Generates a form with a text box
                    AddNewName();
                    break;
                default://displays recognized name from database in text box
                    txtNameSearch.Text = searchName;
                    break;
            }
        }

        /// <summary>
        /// This method is used to switch to a different form to add new name
        /// to the database and then updates it in the log.
        /// </summary>
        private void AddNewName()
        {   //Stop Main form speech recognizer while AddNewName form is being opened.
            recordedSpeech.recognizer.RecognizeAsyncStop();
            frmEnterName formNewName = new frmEnterName();
            formNewName.ShowDialog();
            //Restart Main form speech recognzer when AddNewName form is closed.
            recordedSpeech.recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }
        /// <summary>
        /// This event is called when 'Help' button is clicked.
        /// </summary>       
        private void HelpToolStripMenuItemClick(object sender, EventArgs e)
        {
            DisplayHelp();
        }

        /// <summary>
        /// It displays information the user needs to know about the various commands.
        /// </summary>
        private void DisplayHelp()
        {
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }

        /// <summary>
        /// This event is called when 'Exit' button is clicked.
        /// </summary>  
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            AppExit();
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        private void AppExit()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {   
                Application.Exit();
            }
        }

        /// <summary>
        /// Launched when text box contents change
        /// </summary>
        private void NameSearchTextChange(object sender, EventArgs e)
        {
            if (txtNameSearch.Text!=string.Empty)
            {
                txtNameSearch.Focus();
                txtNameSearch.SelectionStart = txtNameSearch.Text.Length;
                DisplaySearchResult(dbConnection);               
            }
            else
            {
                dgdDisplayResult.DataSource = null;
                dgdDisplayResult.Hide();
            }
        }

        /// <summary>
        /// Matches the word in text box with database names and displays result.
        /// </summary>
        public void DisplaySearchResult(SqlConnection connection)
        {
            connection.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from patient where Name like '" + "%" + txtNameSearch.Text + "%'", connection);
            DataTable patientTable = new DataTable();
            adapt.Fill(patientTable);
            if (patientTable.Rows.Count!=0)
            {
                lblNoResult.Hide();
                dgdDisplayResult.DataSource = patientTable;
                dgdDisplayResult.Show();
            }
            else
            {
                lblNoResult.Show();
                dgdDisplayResult.Hide();
            }                            
            connection.Close();
        }

        /// <summary>
        /// This event is triggered when 'Stop' Icon is clicked by the user 
        /// </summary>
        private void CmdStopClick(object sender, EventArgs e)
        {
            StopMicrophone();
        }

        /// <summary>
        /// It is used to stop receiving voice input from the user
        /// </summary>
        private void StopMicrophone()
        {
            recordedSpeech.recognizer.RecognizeAsyncStop();
            cmdStart.Enabled = true;
            cmdStop.Enabled = false;
            txtNameSearch.Text = string.Empty;
            txtNameSearch.Enabled = false;
        }  

        /// <summary>
        /// Gives shortcut keys for all buttons
        /// </summary>
        /// <param name="e">Used to identify the pressed key</param>
        private void VoiceSearchKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.S)
            {
                EnableMicrophone();
            }
            if (e.Alt == true && e.KeyCode == Keys.T)
            {
                StopMicrophone();
            }
            if (e.Alt == true && e.KeyCode == Keys.F4)
            {
                AppExit();
            }
            if (e.Alt == true && e.KeyCode == Keys.H)
            {
                DisplayHelp();
            }
        }

        /// <summary>
        /// This function is called when 'Start' button is clicked.
        /// </summary>
        private void CmdStartClick(object sender, EventArgs e)
        {
            EnableMicrophone();
        }

        /// <summary>
        /// It enables the microphone to take voice input.
        /// </summary>
        private void EnableMicrophone()
        {
            try
            {
                cmdStart.Enabled = false;
                cmdStop.Enabled = true;
                txtNameSearch.Enabled = true;
                // Takes multiple inputs
                recordedSpeech.recognizer.RecognizeAsync(RecognizeMode.Multiple);
                //Create Event Handler for when the speech is recognized
                recordedSpeech.recognizer.SpeechRecognized += SpeechRecognized;
            }
            catch (Exception exception)
            {
                //Display message to the user and log the exception
                MessageBox.Show(exception.Message.Trim());
                ErrorLog.WriteErrorLog("Unable to start voice recognition due to " + exception.Message + ", occurred at " + DateTime.Now.ToString());
            }
        }

        /// <summary>
        /// Checks database connection
        /// </summary>
        /// <param name="dbConnection">SQL connection along with connection string</param>
        /// <returns>returns true if there is a connection and vice versa.</returns>
        public bool CheckDBConnection(SqlConnection dbConnection)
        {
            bool connectedToDatabase;
            try
            {
                dbConnection.Open();
                dbConnection.Close();
                connectedToDatabase = true;
            }
            catch (SqlException ex)
            {
                connectedToDatabase = false;
                ErrorLog.WriteErrorLog("Unable to connect to database due to " + ex.Message + ", occurred at " + DateTime.Now.ToString());
                MessageBox.Show("Unable to Connect to Database. Application is exiting. Try again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button2,MessageBoxOptions.ServiceNotification);
                Application.Exit();
            }
            return connectedToDatabase;   
        }
    }
}
