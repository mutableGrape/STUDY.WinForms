using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm2
{
    public partial class AreaCalculator : Form
    {
        public AreaCalculator()
        {
            InitializeComponent();
        }

        private void updateVisiblePanels(object sender, EventArgs e)
        {
            rectPanel.Visible = rectRadio.Checked;
            circPanel.Visible = circRadio.Checked;
            triPanel.Visible = triRadio.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rectRadio.Checked)
            {
                try
                {
                    outputTxt.Text = (Int32.Parse(textBox3.Text) * Int32.Parse(textBox4.Text)).ToString();
                }
                catch (FormatException er)
                {
                    outputTxt.Text = "Error, check inputs";
                }
                
            }
            else if (circRadio.Checked)
            {
                try
                {
                    outputTxt.Text = (Math.Pow(Int32.Parse(textBox6.Text), 2) * Math.PI).ToString();
                }
                catch (FormatException er)
                {
                    outputTxt.Text = "Error, check inputs";
                }
            }
            else
            {
                double a, b, c, s;
                try
                {
                    a = Double.Parse(textBox7.Text);
                    b = Double.Parse(textBox8.Text);
                    c = Double.Parse(textBox5.Text);
                }
                catch (FormatException er)
                {
                    outputTxt.Text = "Error, check inputs";
                    return;
                }

                s = 0.5 * (a + b + c);
                String area = (Math.Sqrt(s * (s - a) * (s - b) * (s - c))).ToString();
                if (area == "NaN")
                {
                    outputTxt.Text = "Invalid Triangle";
                } else
                {
                    outputTxt.Text = area.ToString();
                }
            }
        }
    }
}
