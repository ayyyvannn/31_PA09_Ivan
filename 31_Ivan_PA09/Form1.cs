using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_Ivan_PA09
{
    public partial class Form1 : Form
    {
        double userInput;
        double convertedAmount;

        double us = 0.74;
        double yen = 81.97;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Clear();
            txt_Converted.Clear();
            rb_US.Checked = false;
            rb_Yen.Checked = false;
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                userInput = double.Parse(txt_Amount.Text);

                if (rb_US.Checked)
                {
                    convertedAmount = userInput * us;
                    txt_Converted.Text = convertedAmount.ToString();
                }
                else if (rb_Yen.Checked)
                {
                    convertedAmount = userInput * yen;
                    txt_Converted.Text = convertedAmount.ToString();
                }
                else
                {
                    txt_Converted.Text = "Please select a currency.";
                }

                if (userInput < 0)
                {
                    txt_Amount.Text = "Please enter a valid amount.";

                    txt_Converted.Text = " ";
                }
            }
            catch (FormatException)
            {
                txt_Amount.Text = "Please enter a valid amount.";
            }
        }
    }
}
