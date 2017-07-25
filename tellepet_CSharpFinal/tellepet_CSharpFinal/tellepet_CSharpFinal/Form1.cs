using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Evan Tellep
/// Prof. Bill Nicholson
/// Contemporary Programming
/// Final Project
/// 12/6/2016
/// Ref: Stack Overflow | MSDN | Old Projects
/// </summary>

namespace tellepet_CSharpFinal
{
    public partial class EvNav : Form
    {
        //Setting class level variables
        private string addrArgument; //Tells me which field is being edited

        private Button[] keys; //Holds alll of the keys of the keyboard save for the special keys

        private TextBox[] addressSnippets; //Holds the values for each part of the address

        //Start width and height of the form to get it to go back to being small after the keyboard is loaded
        private int startHeight;
        private int startWidth;

        private List<String> allResults = new List<String>(); //An array of the original results returned after query

        //Variables to hold the IDs of what is being entered in the home panel
        private String StateID;
        private String CityID;
        private String StreetID;

        /// <summary>
        /// Where anything that happens on startup should happen
        /// </summary>
        public EvNav()
        {
            //The default initialize method call
            InitializeComponent();

            //Code to set the homepanel to fill the for and grabbing the starting dimensions
            pnlHome.Dock = DockStyle.Fill;
            pnlHome.BringToFront();
            startHeight = ActiveForm.Height;
            startWidth = ActiveForm.Width;

            //Filling the keys array with all my keys! I was excited to figure this out
            keys = new Button[36] { btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI, btnJ,
                btnK, btnL, btnM, btnN, btnO, btnP, btnQ, btnR, btnS, btnT, btnU, btnV, btnW, btnX,
                btnY, btnZ, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0};

            //Setting all the keys' click events to be handled by a single method, that way I don't have a million 'onclick' handlers
            for(int i = 0; i < keys.Length; i++)
            {
                keys[i].Click += keyboardTyping;
            }

            //A similar approach is used to construct the address. Grab each text box and put it in an array
            //and set its handler for textchanged to a custom handler
            addressSnippets = new TextBox[4] { txtState, txtCity, txtStreet, txtStreetNum};
            for (int i = 0; i < addressSnippets.Length; i++)
            {
                addressSnippets[i].TextChanged += constructAddress;
            }

            //Connecting to the database right when the form opens. Lets you know if it succeeds
            if (Utils.CheckConnection())
            {
                MessageBox.Show("Connection succeeded");
            }
            else
            {
                MessageBox.Show("Connection failed.");
                this.Close();
            }
        }

        /// <summary>
        /// If all address fields hold a value the address is constructed in poper order:
        /// Num : Street : City : State
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">Data that has to do with thespecific event</param>
        private void constructAddress(object sender, EventArgs e)
        {
            if (txtState.Text != "" && txtCity.Text != "" && txtStreet.Text != "" && txtStreetNum.Text != "")
            {
                txtAddress.Text = "";
                txtAddress.Text += txtStreetNum.Text + " " + txtStreet.Text + " " + txtCity.Text + " " + txtState.Text;
            }
        }

        /// <summary>
        /// When the enter button is clicked this method checks what field you wanted to edit and inserts the selected value.
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Data pertaining to the even triggered</param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtEntered.Text != "")
            {
                //When enter is pressed it also takes you back to the home form
                //These lines adjust the dimensions of the form and show the home panel
                ActiveForm.Height = startHeight;
                ActiveForm.Width = startWidth;
                pnlHome.Dock = DockStyle.Fill;
                pnlHome.BringToFront();

                //Switches on the addrArgument to determine what field needs updated
                switch (addrArgument)
                {
                    case "State":
                        //Clear the field before entering new value in case someone edits the original value
                        txtState.Clear();
                        //Enter the value
                        txtState.Text += txtEntered.Text;
                        break;
                    case "City":
                        txtCity.Clear();
                        txtCity.Text += txtEntered.Text;
                        break;
                    case "Street":
                        txtStreet.Clear();
                        txtStreet.Text += txtEntered.Text;
                        break;
                    case "StreetNum":
                        txtStreetNum.Clear();
                        txtStreetNum.Text += txtEntered.Text;
                        break;
                }
            }
        }

        /// <summary>
        /// When the state button is clicked it opens up the keyboard panel and filters the initial results based on if any
        /// other field is set
        /// </summary>
        /// <param name="sender">Object that triggered the event</param>
        /// <param name="e">Data pertaining to the event</param>
        private void btnState_Click(object sender, EventArgs e)
        {
            //Removes any text from the textbox in the keyboard panel to reset it if it had been typed in before
            txtEntered.Clear();
            //Clears the results in case it was previously populated
            lstResults.Items.Clear();
            //Clearing allResults in case it was previously populated
            allResults.Clear();
            //Change addrArgument so we know the field to be edited is state
            addrArgument = "State";

            //Bringing the keyboard panel to the front and sizing it
            pnlKeyboard.BringToFront();
            ActiveForm.Height = pnlKeyboard.Height + 35;
            ActiveForm.Width = pnlKeyboard.Width + 15;
            
            //Reset the keys to make all active
            foreach (Button key in keys)
            {
                if (!key.Enabled)
                {
                    key.Enabled = true;
                }
            }

            //The following is logic to filter the initial state results if another field is defined before state
            if (txtCity.Text != "")
            {
                List<String> StateIDs = Utils.MyDLookup("StateID", "tCity", "City='" + txtCity.Text + "'", "");
                foreach (String stateID in StateIDs)
                {
                    List<String> tempStates = Utils.MyDLookup("State", "tState", "StateID=" + stateID, "");
                    foreach (String state in tempStates)
                    {
                        lstResults.Items.Add(state);
                    }
                }
            } else if (txtStreet.Text != "")
            {
                List<String> CityIDs = Utils.MyDLookup("CityID", "tStreet", "Street='" + txtStreet.Text + "'", "");
                foreach (String cityID in CityIDs)
                {
                    List<String> tempStateID = Utils.MyDLookup("StateID", "tCity", "CityID='" + cityID + "'", "");
                    foreach (String tempState in tempStateID)
                    {
                        List<String> tempStateNames = Utils.MyDLookup("State", "tState", "StateID=" + tempState, "");
                        foreach (String state in tempStateNames)
                        {
                            lstResults.Items.Add(state);
                        }
                    }
                }
            } else if (txtStreetNum.Text != "")
            {
                List<String> StreetIDs = Utils.MyDLookup("StreetID", "tStreetNum", "StreetNum='" + txtStreetNum.Text + "'", "");
                foreach (String streetID in StreetIDs)
                {
                    List<String> CityIDs = Utils.MyDLookup("CityID", "tStreet", "StreetID='" + streetID + "'", "");
                    foreach (String cityID in CityIDs)
                    {
                        List<String> tempStateID = Utils.MyDLookup("StateID", "tCity", "CityID='" + cityID + "'", "");
                        foreach (String tempState in tempStateID)
                        {
                            List<String> tempStateNames = Utils.MyDLookup("State", "tState", "StateID=" + tempState, "");
                            foreach (String state in tempStateNames)
                            {
                                lstResults.Items.Add(state);
                            }
                        }
                    }
                }
            } else
            {
                //If no other arguments are defined before State then populate with all results
                readRecords(addrArgument);
            }
        }

        /// <summary>
        /// Brings up the keyboard panel to define city
        /// </summary>
        /// <param name="sender">object that triggered the event</param>
        /// <param name="e">Data that has to do with the event</param>
        private void btnCity_Click(object sender, EventArgs e)
        {
            //Removes any text from the textbox in the keyboard panel to reset it if it had been typed in before
            txtEntered.Clear();
            //Clears the results in case it was previously populated
            lstResults.Items.Clear();
            //Clearing allResults in case it was previously populated
            allResults.Clear();
            //Change addrArgument so we know the field to be edited is city
            addrArgument = "City";

            //Resizes form to fit panel and brings the keyboard panel to front
            pnlKeyboard.BringToFront();
            ActiveForm.Height = pnlKeyboard.Height + 35;
            ActiveForm.Width = pnlKeyboard.Width + 15;

            //Reset the keys so all are active
            foreach (Button key in keys)
            {
                if (!key.Enabled)
                {
                    key.Enabled = true;
                }
            }

            //if the preceding field has been entered grab records only pertaining to the text entered
            if (txtState.Text != "")
            {
                List<String> StateIDs = Utils.MyDLookup("StateID", "tState", "State='" + txtState.Text + "'", "");
                foreach (String stateID in StateIDs)
                {
                    List<String> Cities = Utils.MyDLookup("City", "tCity", "StateID='" + stateID + "'", "");
                    foreach (String city in Cities)
                    {
                        lstResults.Items.Add(city);
                        allResults.Add(city);
                    }
                }
            }
            else
            {
                //Read the default records for streets
                readRecords(addrArgument);
            }
        }

        /// <summary>
        /// Brings up the keyboard panel to define the Street of the address
        /// </summary>
        /// <param name="sender">Object that triggered the event</param>
        /// <param name="e">Data pertaining to the event</param>
        private void btnStreet_Click(object sender, EventArgs e)
        {
            //Removes any text from the textbox in the keyboard panel to reset it if it had been typed in before
            txtEntered.Clear();
            //Clears the results in case it was previously populated
            lstResults.Items.Clear();
            //Clearing allResults in case it was previously populated
            allResults.Clear();
            //Change addrArgument so we know the field to be edited is Street
            addrArgument = "Street";
            pnlKeyboard.BringToFront();
            ActiveForm.Height = pnlKeyboard.Height + 35;
            ActiveForm.Width = pnlKeyboard.Width + 15;

            //Reset the keys so all are active
            foreach (Button key in keys)
            {
                if (!key.Enabled)
                {
                    key.Enabled = true;
                }
            }

            //Populate results with pertinent info
            if (txtCity.Text != "")
            {
                List<String> Streets = Utils.MyDLookup("Street", "tStreet", "CityID='" + CityID + "'", "");
                foreach (String street in Streets)
                {
                    lstResults.Items.Add(street);
                    allResults.Add(street);
                }
            }
            else
            {
                //Read the default records for streets
                readRecords(addrArgument);
            }
        }

        /// <summary>
        /// Brings up the keyboard panel so you can edit Streetnum
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Data pertaining to the event</param>
        private void btnStreetNum_Click(object sender, EventArgs e)
        {
            //Removes any text from the textbox in the keyboard panel to reset it if it had been typed in before
            txtEntered.Clear();
            //Clears the results in case it was previously populated
            lstResults.Items.Clear();
            //Clearing allResults in case it was previously populated
            allResults.Clear();
            //Change addrArgument so we know the field to be edited is streetnum
            addrArgument = "StreetNum";

            //Read the default records for streetnum
            pnlKeyboard.BringToFront();
            ActiveForm.Height = pnlKeyboard.Height + 35;
            ActiveForm.Width = pnlKeyboard.Width + 15;


            //Reset the keys so all are active
            foreach (Button key in keys)
            {
                if (!key.Enabled)
                {
                    key.Enabled = true;
                }
            }

            //Populate results with pertinent info
            if (txtStreet.Text != "")
            {
                List<String> StreetNums = Utils.MyDLookup("StreetNum", "tStreetNum", "StreetID='" + StreetID + "'", "");
                foreach (String streetNum in StreetNums)
                {
                    lstResults.Items.Add(streetNum);
                    allResults.Add(streetNum);
                }
            }
            else
            {
                //Read the default records for streets
                readRecords(addrArgument);
            }

            //Read the default records for streets
            readRecords(addrArgument);
        }

        /// <summary>
        /// Allows someone to delete the ost recently placed character
        /// </summary>
        /// <param name="sender">Object that triggered the event</param>
        /// <param name="e">Data pertaining to the event</param>
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtEntered.Text.Length > 0)
            {
                txtEntered.Text = txtEntered.Text.Remove(txtEntered.Text.Length - 1, 1);
            }
        }

        /// <summary>
        /// Toggles letter case for the whole keyboard
        /// </summary>
        /// <param name="sender">Object triggereing the event</param>
        /// <param name="e">Data pertaining to the event</param>
        private void btnShift_Click(object sender, EventArgs e)
        {
            //The 'A' here is arbitrary. Just needed to grab a button to check case
            if (keys[0].Text == "A")
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    keys[i].Text = keys[i].Text.ToLower();
                }
            }
            else
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    keys[i].Text = keys[i].Text.ToUpper();
                }
            }
        }

        /// <summary>
        /// Allows users to add spaces to their strings entered into the textbox of the keyboard panel
        /// </summary>
        /// <param name="sender">Object that triggered the event</param>
        /// <param name="e">Data pertaining to the event</param>
        private void btnSpace_Click(object sender, EventArgs e)
        {
            txtEntered.Text += " ";
        }

        /// <summary>
        /// Generic event handler for all keys. Grabs the key triggering the event and places it's text into the text box.
        /// Doing this made this much less tedious.
        /// </summary>
        /// <param name="sender">Object triggereing the event</param>
        /// <param name="e">Data pertaining to the event</param>
        private void keyboardTyping(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button key = (Button)sender;
                txtEntered.Text += key.Text;
            }
        }

        /// <summary>
        /// Handles filtering based on what is entered into the textbox of the keyboard panel
        /// </summary>
        /// <param name="sender">Object triggering event</param>
        /// <param name="e">Data pertaining to the event</param>
        private void txtEntered_TextChanged(object sender, EventArgs e)
        {
            //Reset al keys to be enabled
            foreach (Button key in keys)
            {
                if (key.Enabled == false)
                {
                    key.Enabled = true;
                }
            }

            //Keyboard appears being uppercase then after the first letter typed goes to loewrcase
            if (txtEntered.Text != "")
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    keys[i].Text = keys[i].Text.ToLower();
                }
            }
            else
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    keys[i].Text = keys[i].Text.ToUpper();
                }
            }

            //Clears the listbox and repopulates it with the filtered results
            lstResults.Items.Clear();
            for (int i = 0; i < allResults.Count; i++)
            {
                if (allResults[i].Contains(txtEntered.Text))
                {
                    lstResults.Items.Add(allResults[i]);
                }
            }

            //Enables and disables keys based on their relevance to the filtered results
            bool firstIteration = true;
            //Loop through all results
            for (int i = 0; i < lstResults.Items.Count; i++)
            {
                //Loop through all letters
                for (int j = 0; j < keys.Length; j++)
                {
                    //On first result disable all eys not releveant to it
                    if (firstIteration)
                    {
                        if (!Convert.ToString(lstResults.Items[i]).Contains(keys[j].Text))
                        {
                            keys[j].Enabled = false;
                        }
                    }
                    //For all other results enable keys as they become relevant
                    else if (Convert.ToString(lstResults.Items[i]).Contains(keys[j].Text))
                    {
                        if (keys[j].Enabled == false)
                        {
                            keys[j].Enabled = true;
                        }
                    }
                }
                firstIteration = false;
            }
        }

        /// <summary>
        /// Grabs the state id for the state depicted in the text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtState_TextChanged(object sender, EventArgs e)
        {
            List<String> tempStateID = Utils.MyDLookup("StateID", "tState", "State='" + txtState.Text + "'", "");
            StateID = tempStateID[0];
        }

        /// <summary>
        /// Grabs the City id for the city depicted in the text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            List<String> tempCityID = Utils.MyDLookup("CityID", "tCity", "StateID='" + StateID + "'", "");
            foreach (String city in tempCityID)
            {
                List<String> tempCity = Utils.MyDLookup("City", "tCity", "CityID='" + city + "'", "");
                String temp = tempCity[0].Trim();
                if (temp == txtCity.Text)
                {
                    CityID = city;
                }
            }
        }

        /// <summary>
        /// Grabs the street id for the street depicted in the text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStreet_TextChanged(object sender, EventArgs e)
        {
            List<String> tempStreetID = Utils.MyDLookup("StreetID", "tStreet", "Street='" + txtStreet.Text + "'", "");
            StreetID = tempStreetID[0];
        }

        /// <summary>
        /// Allows a user to double click on a result to add it to the textbox pertaining to it
        /// </summary>
        /// <!-- Gets the index of the object in the list box, then select the text from that object and places
        /// it in the corresponding textbox-->
        /// <param name="sender">Object that triggered the event</param>
        /// <param name="e">Data pertaining to the event</param>
        private void lstResults_DoubleClick(object sender, EventArgs e)
        {
            int index = this.lstResults.SelectedIndex;
            txtEntered.Text = (String)lstResults.Items[index];
            String temp = "";
            bool firstSpace = true;
            foreach (char c in txtEntered.Text)
            {
                if (c != ' ')
                {
                    temp += Convert.ToString(c);
                }
                else if (addrArgument == "Street" && c == ' ')
                {
                    if (firstSpace)
                    {
                        temp += Convert.ToString(c);
                    }
                    firstSpace = false;
                }
            }
            txtEntered.Text = temp;
            btnEnter_Click(sender, e);
        }

        /// <summary>
        /// Queries for all results based on the addrArgument
        /// </summary>
        /// <author>Bill Nicholson | Evan Tellep</author>
        /// <param name="addrArgument">The address snippet the user plans to add next</param>
        private void readRecords(String addrArgument)
        {
            Utils.CheckConnection();
            SqlDataReader dr = null;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * from t" + addrArgument + " order by " + addrArgument + "", Config.myConnection);

                // create data adapter
                dr = cmd.ExecuteReader();

                if (lstResults.Items.Count == 0)
                {
                    while (dr.Read())
                    {
                        lstResults.Items.Add(dr.GetString(1));
                        allResults.Add(dr.GetString(1));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // If we can't close the data reader, just eat the exception
                try { dr.Close(); } catch (Exception ex) { }
            }
        }
    }
}
