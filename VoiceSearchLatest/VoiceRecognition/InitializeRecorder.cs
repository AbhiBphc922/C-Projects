using System.Speech.Recognition;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace Voice_PM_Search
{
    /// <summary>
    /// This class is used to load grammar for Voice PM Search form.
    /// </summary>
    public class InitializeRecorder
    {
        //Declaring SpeechRecognitionEngine that converts speech to text
        public SpeechRecognitionEngine recognizer;

        /// <summary>
        /// Used to Load Grammar into Speech Engine
        /// </summary>
        public InitializeRecorder()
        {
            recognizer = new SpeechRecognitionEngine();
            recognizer.LoadGrammarAsync(new DictationGrammar());
        }
        /// <summary>
        /// Adds grammar from database to recognizer.
        /// </summary>
        public void CreateGrammar(SqlConnection connection)
        {
            SqlCommand getNamesCommand = new SqlCommand();
            GrammarBuilder grammarBuilderForSearchName = new GrammarBuilder();
            List<string> NameLibrary = new List<string>();
            Choices names = new Choices();
            getNamesCommand.Connection = connection;
            try
            {
                connection.Open();
                string sqlGet = "select Name from Patient";
                getNamesCommand = new SqlCommand(sqlGet, connection);
                using (SqlDataReader reader = getNamesCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NameLibrary.Add(reader.GetString(0).Replace(" ", ""));
                    }
                }
                connection.Close();
                if (NameLibrary.Count > 0)
                {
                    foreach (string word in NameLibrary)
                    {
                        names.Add(word);
                    }
                    grammarBuilderForSearchName.Append(names);
                    recognizer.LoadGrammarAsync(new Grammar(grammarBuilderForSearchName));
                }
                else
                {
                    throw new FormatException("Grammar cannot be null");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to Database. Application is exiting. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLog.WriteErrorLog("Error due to " + ex.Message + ", occurred at " + DateTime.Now.ToString());
                Application.Exit();
            }
        }
    }
}
