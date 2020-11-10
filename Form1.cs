using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalcApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ActiveField = 0;
        char symbol;
        public void Inputter(ref char symbol)
        {
            switch (ActiveField)
            {
                case 0:
                    field_HA.Text += symbol;
                    break;
                case 1:
                    field_HB.Text += symbol;
                    break;
                case 2:
                    field_DA.Text += symbol;
                    break;
                case 3:
                    field_DB.Text += symbol;
                    break;
            }
        }

        private void HEX_Deactivate()
        {
            bA.Enabled = false;
            bB.Enabled = false;
            bC.Enabled = false;
            bD.Enabled = false;
            bE.Enabled = false;
            bF.Enabled = false;
        }
        private void HEX_Activate()
        {
            bA.Enabled = true;
            bB.Enabled = true;
            bC.Enabled = true;
            bD.Enabled = true;
            bE.Enabled = true;
            bF.Enabled = true;
        }
        private void field_HA_Enter(object sender, EventArgs e)
        {
            HEX_Activate();
            ActiveField = 0;
        }
        private void field_HB_Enter(object sender, EventArgs e)
        {
            HEX_Activate();
            ActiveField = 1;
        }
        private void field_DA_Enter(object sender, EventArgs e)
        {
            HEX_Deactivate();
            ActiveField = 2;
        }
        private void field_DB_Enter(object sender, EventArgs e)
        {
            HEX_Deactivate();
            ActiveField = 3;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            symbol = '1';
            Inputter(ref symbol);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            symbol = '2';
            Inputter(ref symbol);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            symbol = '3';
            Inputter(ref symbol);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            symbol = '4';
            Inputter(ref symbol);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            symbol = '5';
            Inputter(ref symbol);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            symbol = '6';
            Inputter(ref symbol);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            symbol = '7';
            Inputter(ref symbol);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            symbol = '8';
            Inputter(ref symbol);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            symbol = '9';
            Inputter(ref symbol);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            symbol = '0';
            Inputter(ref symbol);
        }

        private void bA_Click(object sender, EventArgs e)
        {
            symbol = 'a';
            Inputter(ref symbol);
        }

        private void bB_Click(object sender, EventArgs e)
        {
            symbol = 'b';
            Inputter(ref symbol);
        }

        private void bC_Click(object sender, EventArgs e)
        {
            symbol = 'c';
            Inputter(ref symbol);
        }

        private void bD_Click(object sender, EventArgs e)
        {
            symbol = 'd';
            Inputter(ref symbol);
        }

        private void bE_Click(object sender, EventArgs e)
        {
            symbol = 'e';
            Inputter(ref symbol);
        }

        private void bF_Click(object sender, EventArgs e)
        {
            symbol = 'f';
            Inputter(ref symbol);
        }
    }
}
