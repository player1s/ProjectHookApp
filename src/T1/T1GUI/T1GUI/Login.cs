using System;
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
            MLogin mLogin = new MLogin();
            mLogin.PhoneNumber = textBox1.Text;
            mLogin.Password = textBox2.Text;
            if((mLogin.PhoneNumber).Equals("") || mLogin.Password.Equals(""))
            {
                mLogin.Password = "none";
                mLogin.PhoneNumber= "none";
            }
            System.Console.WriteLine("Bout to send: {0} {1}", mLogin.PhoneNumber, mLogin.Password);
            label3.Text = Client.Login(mLogin).GetAwaiter().GetResult();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
