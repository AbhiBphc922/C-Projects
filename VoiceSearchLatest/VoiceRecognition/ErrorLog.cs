using System;
using System.Windows.Forms;
namespace Voice_PM_Search
{   
    /// <summary>
    /// Used to write to a file when an error is occurred.
    /// </summary>
    public static class ErrorLog
    {   
        /// <summary>
        /// Used to write errorText to a file.
        /// </summary>
        /// <param name="errorText">It contains the exception message and the timestamp of its occurrence.</param>
        public static void WriteErrorLog(string errorText)
        {
            try
            {
                //Declare the file name for the Error log.
                string fileName = "errorLog.txt";
                // Folder where the log file has to be stored. Here, it is Path of the current Application.
                string filePath = Application.StartupPath;
                // write the error message and timestamp to error file.
                System.IO.File.AppendAllText(filePath + "\\" + fileName, errorText + ", logged at " + DateTime.Now.ToString()+"."+Environment.NewLine);
            }
            catch (Exception ex)
            {
                WriteErrorLog("Error in WriteErrorLog method :" + ex.Message.Trim());
            }
        }
    }
}
