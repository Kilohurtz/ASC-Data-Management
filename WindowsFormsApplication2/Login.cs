﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your name.", "Sign In",
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                Main main = new Main();
                this.Hide();
                main.setName(textBox1.Text);
                main.ShowDialog();
                textBox1.Text = "";
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}