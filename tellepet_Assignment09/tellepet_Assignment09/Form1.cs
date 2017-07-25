using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Evan Tellep
/// Prof. Bill Nicholson
/// Assignment 09
/// Due: 11/10/2016
/// Summary: The class to handle the form
/// </summary>
namespace tellepet_Assignment09
{
    public partial class SpamChecker : Form
    {
        public SpamChecker()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fires when the browse button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Set the initial directory of the file dialog to the relevant destination
            diaBrowseFile.InitialDirectory = Environment.CurrentDirectory;
            //Showing the dialog and setting it's results to a variable
            DialogResult result = diaBrowseFile.ShowDialog();
            //If the results are valid...
            if (result == DialogResult.OK) {
                //Open the file that was selected
                System.IO.Stream stream = diaBrowseFile.OpenFile();
                //Display that message within the webBrowser
                MsgReader.Reader reader = new MsgReader.Reader();
                string msg = reader.ExtractMsgEmailBody(stream, true, "text/html");
                webMsg.DocumentText = msg;
            }
        }

        /// <summary>
        /// Fires when the Check spam button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpam_Click(object sender, EventArgs e)
        {
            //read the message that was selected and run it through the spam checking method to print out the count of spam words in the message
            MsgReader.Reader reader = new MsgReader.Reader();
            System.IO.Stream stream = diaBrowseFile.OpenFile();
            string msg = reader.ExtractMsgEmailBody(stream, true, "text");
            txtSpamFound.Text = Convert.ToString(Spam.spamCheck(msg)) + " spam words were found!";
        }
    }
}
