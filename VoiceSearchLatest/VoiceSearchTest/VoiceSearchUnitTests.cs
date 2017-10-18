using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Voice_PM_Search;
using System.Data.SqlClient;
using Moq;
namespace VoiceSearchTest
{
    /// <summary>
    /// A test class to test the methods of Voice_PM_Search
    /// </summary>
    [TestClass]
    public class VoiceSearchUnitTests
    {   
        /// <summary>
        /// A test to check the behaviour of testCheckDbConnection when connection string is wrong.
        /// </summary>
        [TestMethod]
        public void TestCheckDBConnection1()
        {
            frmVoiceSearch testForDBConnection1 = new frmVoiceSearch();
            SqlConnection testConnection1 = new SqlConnection(@"Data Source=(ocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VoiceSearch\VoiceRecognition\Patient_Details.mdf;Integrated Security=True");           
            bool expected = testForDBConnection1.CheckDBConnection(testConnection1);
            Assert.AreEqual(false,expected);
        }

        /// <summary>
        /// A test to check the behaviour of testCheckDbConnection when connection string is correct.
        /// </summary>
        [TestMethod]
        public void TestCheckDBConnection2()
        {
            frmVoiceSearch testForDBConnection1 = new frmVoiceSearch();
            SqlConnection testConnection1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VoiceSearch\VoiceRecognition\Patient_Details.mdf;Integrated Security=True");
            bool expected = testForDBConnection1.CheckDBConnection(testConnection1);
            Assert.AreEqual(true, expected);
        }
        /// <summary>
        /// A test to check behaviour of displaySearchResult when connection string is empty.
        /// </summary>
        [TestMethod]
        public void TestDisplaySearchResult1()
        {
            frmVoiceSearch testForSearchResult1 = new frmVoiceSearch();
            SqlConnection testConnection3 = new SqlConnection();
            Exception caughtException = null;
            try
            {
                testForSearchResult1.DisplaySearchResult(testConnection3);
            }
            catch (Exception ex)
            {
                caughtException = ex;
            }
            Assert.IsNotNull(caughtException);
        }

        /// <summary>
        /// A test to check behaviour of displaySearchResult when connection string is wrong.
        /// </summary>
        [TestMethod]
        public void TestDisplaySearchResult2()
        {
            frmVoiceSearch testForSearchResult2 = new frmVoiceSearch();
            SqlConnection testConnection4 = new SqlConnection(@"Data Source=(ocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VoiceSearch\VoiceRecognition\Patient_Details.mdf;Integrated Security=True");
            Exception caughtException = null;
            try
            {
                testForSearchResult2.DisplaySearchResult(testConnection4);
            }
            catch (Exception ex)
            {
                caughtException = ex;
            }
            Assert.IsNotNull(caughtException);
        }

        /// <summary>
        /// A test to check the behaviour of AddNameToDatabase when connection string is empty.
        /// </summary>
        [TestMethod]
        public void TestAddNameToDatabase1()
        {
            frmEnterName testForAddNameToDatabase1 = new frmEnterName();
            SqlConnection testConnection5 = new SqlConnection();
            Exception caughtException = null;
            try
            {
                testForAddNameToDatabase1.AddNameToDatabase("Random", testConnection5);
            }
            catch (Exception ex)
            {
                caughtException = ex;
            }
            Assert.IsNotNull(caughtException);
        }

        /// <summary>
        /// A test to check the behaviour of AddNameToDatabase when connection string is wrong.
        /// </summary>
        [TestMethod]
        public void TestAddNameToDatabase2()
        {
            frmEnterName testForAddNameToDatabase2 = new frmEnterName();
            SqlConnection testConnection6 = new SqlConnection(@"Data Source=(ocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VoiceSearch\VoiceRecognition\Patient_Details.mdf;Integrated Security=True");
            Exception caughtException = null;
            try
            {
                testForAddNameToDatabase2.AddNameToDatabase("Random", testConnection6);
            }
            catch (Exception ex)
            {
                caughtException = ex;
            }

            Assert.IsNotNull(caughtException);
        }

        /// <summary>
        /// A test to check behavior of createGrammar when connection string correct.
        /// </summary>
        [TestMethod]
        public void TestForCreateGrammar1()
        {
            InitializeRecorder testForCreateGrammar1 = new InitializeRecorder();
            frmVoiceSearch testForCreateGrammar = new frmVoiceSearch();
            SqlConnection testConnection7 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VoiceSearch\VoiceRecognition\Patient_Details.mdf;Integrated Security=True");
            testForCreateGrammar1.CreateGrammar(testConnection7);
            Assert.AreEqual(testForCreateGrammar1.recognizer.Grammars.Count, 2);
        }

        /// <summary>
        /// A test to check behavior of createGrammar when null database connection string is given.
        /// </summary>
        [TestMethod]
        public void TestForCreateGrammar2()
        {
            InitializeRecorder testForCreateGrammar2 = new InitializeRecorder();
            SqlConnection testConnection8 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VoiceSearch\VoiceRecognition\TestDatabase.mdf;Integrated Security=True");
            testForCreateGrammar2.CreateGrammar(testConnection8);
            Assert.AreEqual(testForCreateGrammar2.recognizer.Grammars.Count, 1);
        }
    }
}
