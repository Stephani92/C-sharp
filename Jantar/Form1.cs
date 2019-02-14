using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jantar
{
    public partial class Form1 : Form
    {
        Birth birth;
        Dinner dinner;
        public Form1()
        {
            InitializeComponent();

            //Birth

            birth = new Birth((int)numericUpDown1.Value, cBoxFancyCake.Checked, cBoxHealthyCake.Checked);
            birth.CalculationCostOfDecorations(cBoxFancyCake.Checked);
            birth.SetHealthyOption(cBoxHealthyCake.Checked);
            DisplayBirth();
            // Dinner

            dinner = new Dinner((int)numericUpDown2.Value, cBoxFancy.Checked, cBoxHealthy.Checked);
            dinner.SetHealthyOption(cBoxHealthy.Checked);
            dinner.CalculationCostOfDecorations(cBoxFancy.Checked);
            DisplayDinner();
        }
        private void DisplayBirth()
        {
            decimal cost = birth.CalculateCost(cBoxHealthyCake.Checked);
            txBoxCostBirth.Text = cost.ToString("c"); 
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            birth.NumberofPeople = (int)numericUpDown1.Value;
            birth.CalculCakeSize();
            birth.CalculationCostOfDecorations(cBoxFancyCake.Checked);
            DisplayBirth();
        }

        private void cBoxFancyCake_CheckedChanged(object sender, EventArgs e)
        {
            birth.CalculationCostOfDecorations(cBoxFancyCake.Checked);
            DisplayBirth();
        }

        private void cBoxHealthyCake_CheckedChanged(object sender, EventArgs e)
        {
            birth.SetHealthyOption(cBoxHealthyCake.Checked);
            DisplayBirth();
        }

        private void txBoxCakeWriting_TextChanged(object sender, EventArgs e)
        {
            birth.cakeWriting = txBoxCakeWriting.Text;
            DisplayBirth();
        }

        // Dinner
        private void DisplayDinner()
        {
            decimal Cost = dinner.CalculateCost(cBoxHealthy.Checked);
            TxBoxCostDinner.Text = Cost.ToString("c");
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dinner.NumberofPeople = (int)numericUpDown2.Value;
            dinner.CalculationCostOfDecorations(cBoxFancy.Checked);
            DisplayDinner();
        }

        private void cBoxFancy_CheckedChanged(object sender, EventArgs e)
        {
            dinner.CalculationCostOfDecorations(cBoxFancy.Checked);
            DisplayDinner();
        }

        private void cBoxHealthy_CheckedChanged(object sender, EventArgs e)
        {
            dinner.SetHealthyOption(cBoxHealthy.Checked);
            DisplayDinner();
        }
    }
}
