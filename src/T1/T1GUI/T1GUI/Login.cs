﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace T1GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "got to this point";
            string s = Client.GetData().GetAwaiter().GetResult();
            //System.Console.WriteLine();
            label2.Text = s;
            label1.Text = "this too?";
            // this.Hide();
            //MatchMaker mm = new MatchMaker();
            //mm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Welcome w = new Welcome();
            w.ShowDialog();
        }
    }
}
