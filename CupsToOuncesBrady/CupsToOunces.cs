using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : Cups to Ounces
* Author      : Kabrina Brady
* Created     : 11/10/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : Program converts cups (user input) to fluid ounces
*               Input:  Cups, button/keyboard clicks
*               Output: Ounces
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace CupsToOuncesBrady
{
    public partial class CupsToOuncesForm : Form
    {
        public CupsToOuncesForm()
        {
            InitializeComponent();
        }

        //The CupsToOunces method accepts number of cups as an argument and returns the equivalent number of fluid ounces
        public double CupsToOunces(double cups)
        {
            return cups * 8.0;
        }

        public void btnConvert_Click(object sender, EventArgs e)
        {
            //variables to hold cups and ounces
            double cups, ounces;

            if (double.TryParse(txtCupsInput.Text, out cups))
            {
                //convert cups to ounces
                ounces = CupsToOunces(cups);

                //display ounces
                lblOuncesOutput.Text = ounces.ToString("n1");
            }
            else
            {
                //display error message
                MessageBox.Show("Enter a valid number.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closes form
        }
    }
}
