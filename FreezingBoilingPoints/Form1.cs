using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreezingBoilingPoints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowEffect_Click(object sender, EventArgs e)
        {
            double temperature;
            temperature = Convert.ToDouble(txtBoxInput.Text);
            if (temperature <= -173)
            {
                txtBoxEthyl.Text = "Freezes";
            }
            else if (temperature >= 172)
            {
                txtBoxEthyl.Text = "Boils";
            }
            else
            {
                txtBoxEthyl.Text = "No Change";
            }
            if (temperature <= -38)
            {
                txtBoxMercury.Text = "Freezes";
            }
            else if (temperature >= 676)
            {
                txtBoxMercury.Text = "Boils";
            }
            else
            {
                txtBoxMercury.Text = "No Change";
            }
            if (temperature <= -362)
            {
                txtBoxOxygen.Text = "Freezes";
            }
            else if (temperature >= -306)
            {
                txtBoxOxygen.Text = "Boils";
            }
            else
            {
                txtBoxOxygen.Text = "No Change";
            }
            if (temperature <= 32)
            {
                txtBoxWater.Text = "Freezes";
            }
            else if (temperature >= 212)
            {
                txtBoxWater.Text = "Boils";
            }
            else
            {
                txtBoxWater.Text = "No Change";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxInput.Clear();
            txtBoxEthyl.Clear();
            txtBoxMercury.Clear();
            txtBoxOxygen.Clear();
            txtBoxWater.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
