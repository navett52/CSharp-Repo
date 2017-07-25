using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Evan Tellep
/// Prof. Bill Nicholson
/// Assignment 08
/// 11/3/2016
/// A form for a binary adder class with various bells and whistles added in
/// Ref: MSDN; Stack Overflow;
/// </summary>

namespace tellepet_Assignment08
{
    public partial class Binary_Calculator : Form
    {
        public Binary_Calculator()
        {
            //Initializing compnents of the form
            InitializeComponent();
            //Since I am using a disabled text box to store color it disables the backcolor property so I have to re-set the backcolor to white
            if (txtResult.Enabled == false)
            {
                txtResult.BackColor = Color.White;
            }
        }

        private void txtBinaryNum1_Enter(object sender, EventArgs e)
        {
            //Gets rid of the placeholder text if the text box is in focus
            txtBinaryNum1.Text = "";
        }

        private void txtBinaryNum2_Enter(object sender, EventArgs e)
        {
            //Gets rid of the placeholder text if the text box is in focus
            txtBinaryNum2.Text = "";
        }

        private void txtBinaryNum1_Leave(object sender, EventArgs e)
        {
            //Adds the placeholder text back to the text box when the text box is no longer in focus
            if (txtBinaryNum1.Text == "")
            {
                txtBinaryNum1.Text = "Enter your first binary number";
            }
        }

        private void txtBinaryNum2_Leave(object sender, EventArgs e)
        {
            //Adds the placeholder text back to the text box when the text box is no longer in focus
            if (txtBinaryNum2.Text == "")
            {
                txtBinaryNum2.Text = "Enter your second binary number";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Output the result of the calculation into the result textbox at the bottom of the form
            //This includes errors as well
            txtResult.Text = Binary.AddBinary(txtBinaryNum1.Text, txtBinaryNum2.Text);
        }
    }
}
