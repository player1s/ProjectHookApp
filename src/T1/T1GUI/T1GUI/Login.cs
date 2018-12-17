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
        private String id = "Unknown--";
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
            mLogin.Command = "Login";
            mLogin.PhoneNumber = textBox1.Text;
            this.id = textBox1.Text;
            mLogin.Password = textBox2.Text;
            string id = textBox1.Text;
             
            if((mLogin.PhoneNumber).Equals("") || mLogin.Password.Equals(""))
            {
                mLogin.Password = "none";
                mLogin.PhoneNumber= "none";
            }
            System.Console.WriteLine("Bout to send: {0} {1}", mLogin.PhoneNumber, mLogin.Password);
            label3.Text = Client.PostLogin(mLogin).GetAwaiter().GetResult();
            if(label3.Text.Equals("Logging in!"))
            {
                ISession session = new Session(textBox1.Text);
                this.Hide();
                MatchMaker mm = new MatchMaker(id);
                
                mm.ShowDialog();
            }
            
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
        public string getID()
        {
            return id;
        }
    }
}
