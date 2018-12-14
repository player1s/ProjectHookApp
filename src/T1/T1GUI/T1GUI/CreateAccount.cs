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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MCreateAcc mCreateAcc = new MCreateAcc();

            if (!(textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals("") || textBox5.Text.Equals("") || textBox6.Text.Equals("") || textBox7.Text.Equals("")))
            {
                
                mCreateAcc.Command = "CreateAcc";
                mCreateAcc.PhoneNumber = textBox6.Text;
                mCreateAcc.FirstName = textBox5.Text;
                mCreateAcc.LastName = textBox1.Text;
                mCreateAcc.Gender = textBox2.Text;
                mCreateAcc.Description= textBox3.Text;
                mCreateAcc.Age = textBox4.Text;
                mCreateAcc.Password = textBox7.Text;

                System.Console.WriteLine("Bout to send: {0} {1} {2} {3} {4} {5} {6} {7}",mCreateAcc.Command, mCreateAcc.PhoneNumber, mCreateAcc.FirstName, mCreateAcc.LastName, mCreateAcc.Gender, mCreateAcc.Description, mCreateAcc.Age, mCreateAcc.Password);
                label5.Text = Client.Login(mCreateAcc).GetAwaiter().GetResult();

                /*
                this.Hide();
                MatchMaker mm = new MatchMaker();
                mm.ShowDialog();
                */
            }
            else
            {
                label5.Text = "Please Fill all the boxes";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
