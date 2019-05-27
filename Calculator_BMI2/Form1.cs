using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_BMI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textNama2.ReadOnly = true;
            textNIM2.ReadOnly = true;
            textYourBMI.ReadOnly = true;
            textBMICategories.ReadOnly = true;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textName.Text = String.Empty;
            textNIM.Text = String.Empty;
            textHeight.Text = String.Empty;
            textWeight.Text = String.Empty;
            textNama2.Text = String.Empty;
            textNIM2.Text = String.Empty;
            textYourBMI.Text = String.Empty;
            textBMICategories.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Height, BMI1, Weight, BMI2;
            string Name, NIM;
            Name = textName.Text;
            NIM = textNIM.Text;
            Height = Convert.ToDouble(textHeight.Text);
            Weight = Convert.ToDouble(textWeight.Text);
            textNama2.Text = "" + Name;
            textNIM2.Text = "" + NIM;
            

            BMI1 = Height * Height;
            BMI2 = Weight / BMI1;
            textYourBMI.Text = "" + BMI2;
            if (BMI2 < 16)
            {
                textBMICategories.Text = "Tidak Terdaftar";
            }
            else if (16 < BMI2 && BMI2 <= 18.5)
            {
                textBMICategories.Text = "UnderWeight";
            }
            else if (18.5 < BMI2 && BMI2 <= 25)
            {
                textBMICategories.Text = "Normal";
            }
            else if (25 < BMI2 && BMI2 <= 30)
            {
                textBMICategories.Text = "Overweight";
            }
            else if (30 < BMI2 && BMI2 < 35)
            {
                textBMICategories.Text = "Obesity";
            }
            else if (35 < BMI2)
            {
                textBMICategories.Text = "Tidak Terdaftar";
            }
            
            
        }

        private void textYourBMI_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBMICategories_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textNama2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NIM2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
