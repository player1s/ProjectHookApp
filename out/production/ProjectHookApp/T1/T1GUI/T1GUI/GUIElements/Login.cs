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
        // button1 = Login, once this button is pressed, the elements of the filled checkbox will be used to set up, then to make the login request
        private void button1_Click(object sender, EventArgs e)
        {
            //initialize the login-command object and its variables
            MLogin mLogin = new MLogin();
            mLogin.Command = "Login";
            mLogin.PhoneNumber = textBox1.Text;
            mLogin.Password = textBox2.Text;
            string id = textBox1.Text;
            IClient client = new Client();
             
            //if statement to to eliminate the chances of inputting illegal values, that would cause exceptions
            if((mLogin.PhoneNumber).Equals("") || mLogin.Password.Equals(""))
            {
                mLogin.Password = "none";
                mLogin.PhoneNumber= "none";
            }

            // make the request
            System.Console.WriteLine("Bout to send: {0} {1}", mLogin.PhoneNumber, mLogin.Password);
            label3.Text = client.PostLogin(mLogin).GetAwaiter().GetResult();

            //if statement to determine a successful login
            if(label3.Text.Equals("Logging in!"))
            {
                this.Hide();
                MatchMaker mm = new MatchMaker(id);
                mm.ShowDialog();
            }
            
        }

        // back button to go back one screen
        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Welcome w = new Welcome();
            w.ShowDialog();
        }
    }
}
