using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clearButton.Enabled = false;
            clearButton.Visible = false;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            confirmButton.Enabled = false;
            confirmButton.Visible = false;
            clearButton.Enabled = true;
            clearButton.Visible = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            confirmButton.Enabled = true;
            confirmButton.Visible = true;
            clearButton.Enabled = false;
            clearButton.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(comboBox1.Items[comboBox1.SelectedIndex]);
            // List<Panel> equation = new List<Panel>();
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            switch (n)
            {
                case 1:
                    panel5.Visible = false;
                    panel4.Visible = false;
                    panel3.Visible = false;
                    panel2.Visible = false;
                    break;
                case 2:
                    panel5.Visible = false;
                    panel4.Visible = false;
                    panel3.Visible = false;
                    break;
                case 3:
                    panel5.Visible = false;
                    panel4.Visible = false;
                    break;
                case 4:
                    panel5.Visible = false;
                    break;
                default:
                    break;
            }
            // equation.Add()
        }
    }
}
