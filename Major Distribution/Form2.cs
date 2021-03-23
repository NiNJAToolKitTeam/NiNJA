using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Major_Distribution
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This script is easily detected, and could ban you from a Game. Please be careful of using this script on games like: JailBreak, Pathom Forces, and Mad City!", "NiNJA ToolKit!");
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lagging in Progress!", "NiNJA ToolKit!");
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label5.Text = "Username: " + Dns.GetHostName();
            foreach (IPAddress address in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                label3.Text = "IP: " + address;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entering Main Menu!", "NiNJA ToolKit!");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
