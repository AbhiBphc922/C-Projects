using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace Voice_PM_Search
{   

    /// <summary>
    /// This form is used to add name to the Patient database.
    /// </summary>
    public partial class frmEnterName : Form
    {
        internal SpeechRecognitionEngine nameRecognizer;
        frmVoiceSearch mainForm = new frmVoiceSearch();

        //List of commands
        List<string> commandList = new List<string> {"exit","type"};
        public frmEnterName()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Used to setup a new speech recognition engine
        /// </summary>
        private void frmEnterNameLoad(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            lblInvalidInput.Visible = false;
            //Calls method to load the grammar into speech recognition engine
            Initialize();
            //Set Input to Microphone
            nameRecognizer.SetInputToDefaultAudioDevice();
            // Takes multiple inputs
            nameRecognizer.RecognizeAsync(RecognizeMode.Multiple);
            //Event Handler for Speech Recognition in frmNewName form
            nameRecognizer.SpeechRecognized += NameRecognized;
            txtName.MaxLength = 20;
        }

        /// <summary>
        /// Used to enter a new name for adding functionality
        /// </summary>
        /// <param name="e">Recognized text</param>
        private void NameRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            txtName.Text += e.Result.Text.ToString();
        }

        /// <summary>
        /// Used to clear name text box
        /// </summary>
        private void CmdClearClick(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
        }

        /// <summary>
        /// Launched when 'Save' button is clicked.
        /// </summary>
        private void CmdSaveClick(object sender, EventArgs e)
        {   
            //calls function for adding name to database
            AddNameToDatabase(txtName.Text, mainForm.dbConnection);
        }

        /// <summary>
        /// Used to add name to database
        /// </summary>
        public void AddNameToDatabase(string addName,SqlConnection connection)
        {
            if (addName!=string.Empty)
            {
                if (commandList.IndexOf(addName.ToLower())>=0)
                {
                    MessageBox.Show(addName + " is a keyword and cannot be added to the database as a name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtName.Text = string.Empty;
                }
                else
                {
                    //Stops recognizer temporarily before adding name to database
                    nameRecognizer.RecognizeAsyncStop();
                    connection.Open();
                    SqlCommand insertNameCommand = connection.CreateCommand();
                    insertNameCommand.CommandText = "Insert into Patient (Name) values('" + addName + "')";
                    insertNameCommand.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Added " + addName + " !", "Database Updated", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtName.Text = string.Empty;
                    nameRecognizer.RecognizeAsync(RecognizeMode.Multiple);
                }
            }
            else
            {
                if (txtName.Text == string.Empty)
                {   
                    //Displays label prompting the user to enter valid input
                    lblInvalidInput.Show();
                }
            }
        }
            
        /// <summary>
        /// Used to switch back to main form.
        /// </summary>
        private void BackToolStripMenuItemClick(object sender, EventArgs e)
        {   
            //Stops Name Speech recognizer before switching to main form
            nameRecognizer.RecognizeAsyncStop();
            this.Close();
        }

        /// <summary>
        /// Used to specify shortcut keys for the Add Name form.
        /// </summary>
        private void frmEnterNameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                BackToolStripMenuItemClick(sender, e);
            }
            if(e.Control==true && e.KeyCode == Keys.S)
            {
                CmdSaveClick(sender,e);
            }
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                CmdClearClick(sender, e);
            }
        }

        /// <summary>
        /// Loads Speech Engine with the required Grammar.
        /// </summary>
        private void Initialize()
        {
            nameRecognizer = new SpeechRecognitionEngine();
            Choices alphabets = new Choices();
            string[] letters = new string[26];
            int letterCounter = 0;
            for (char c = 'A'; c <= 'Z'; c++)
            {
                letters[letterCounter] = c.ToString();
                letterCounter++;
            }
            alphabets.Add(letters);
            GrammarBuilder grammarBuilderForAddName = new GrammarBuilder();
            grammarBuilderForAddName.Append(alphabets);
            Grammar grammarForAddName = new Grammar(grammarBuilderForAddName);
            nameRecognizer.LoadGrammarAsync(grammarForAddName);
        }

        /// <summary>
        /// This event is triggered when name text box changes
        /// </summary>
        private void NameTextBoxChanged(object sender, EventArgs e)
        {   
            //Keeps text box in focus while entering and clearing name
            txtName.Focus();
            //Cursor keeps up with the letters while entering name
            txtName.SelectionStart = txtName.Text.Length;
        }
    }
}
