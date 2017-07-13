using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentance_Builder
{
    public partial class Form1 : Form
    {private string strTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            strTotal += "a";
            lblOutput.Text = strTotal;
        }

        private void btnCapA_Click(object sender, EventArgs e)
        {
            strTotal += "A";
            lblOutput.Text = strTotal;
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            strTotal += "an";
            lblOutput.Text = strTotal;
        }

        private void btnCapAn_Click(object sender, EventArgs e)
        {
            strTotal += "An";
            lblOutput.Text = strTotal;
        }

        private void btnCapthe_Click(object sender, EventArgs e)
        {
            strTotal += "The";
            lblOutput.Text = strTotal;
        }

        private void btnThe_Click(object sender, EventArgs e)
        {
            strTotal += "the";
            lblOutput.Text = strTotal;
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            strTotal += "man";
            lblOutput.Text = strTotal;
        }

        private void btnWoman_Click(object sender, EventArgs e)
        {
            strTotal += "woman";
            lblOutput.Text = strTotal;
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            strTotal += "dog";
            lblOutput.Text = strTotal;
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            strTotal += "cat";
            lblOutput.Text = strTotal;
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            strTotal += "car";
            lblOutput.Text = strTotal;
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            strTotal += "bicycle";
            lblOutput.Text = strTotal;
        }

        private void btnBeautiful_Click(object sender, EventArgs e)
        {
            strTotal += "beautiful";
            lblOutput.Text = strTotal;
        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            strTotal += "big";
            lblOutput.Text = strTotal;
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            strTotal += "small";
            lblOutput.Text = strTotal;
        }

        private void btnStrange_Click(object sender, EventArgs e)
        {
            strTotal += "strange";
            lblOutput.Text = strTotal;

        }

        private void btnLookedAt_Click(object sender, EventArgs e)
        {
            strTotal += "looked at";
            lblOutput.Text = strTotal;
        }

        private void btnRode_Click(object sender, EventArgs e)
        {
            strTotal += "rode";
            lblOutput.Text = strTotal;
        }

        private void btnSpokeTo_Click(object sender, EventArgs e)
        {
            strTotal += "spoke to";
            lblOutput.Text = strTotal;
        }

        private void btnLaughedAt_Click(object sender, EventArgs e)
        {
            strTotal += "laughed at";
            lblOutput.Text = strTotal;
        }

        private void btnDrove_Click(object sender, EventArgs e)
        {
            strTotal += "drove";
            lblOutput.Text = strTotal;
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            strTotal += " ";
            lblOutput.Text = strTotal;
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            strTotal += ". ";
            lblOutput.Text = strTotal;
        }

        private void btnExclamation_Click(object sender, EventArgs e)
        {
            strTotal += "! ";
            lblOutput.Text = strTotal;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            strTotal = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
