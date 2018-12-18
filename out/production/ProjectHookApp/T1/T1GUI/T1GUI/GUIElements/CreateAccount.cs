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
            IClient client = new Client();

            // if statement to catch potential illegal values that could cause exceptions later on
            if (!(textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals("") || textBox5.Text.Equals("") || textBox6.Text.Equals("") || textBox7.Text.Equals("")))
            {
                // prepare the object with the user input
                mCreateAcc.Command = "CreateAcc";
                mCreateAcc.PhoneNumber = textBox6.Text;
                mCreateAcc.FirstName = textBox5.Text;
                mCreateAcc.LastName = textBox1.Text;
                mCreateAcc.Gender = textBox2.Text;
                mCreateAcc.Description= textBox3.Text;
                mCreateAcc.Age = textBox4.Text;
                mCreateAcc.Password = textBox7.Text;

                //Send, then receive a reaponse to the request
                System.Console.WriteLine("Bout to send: {0} {1} {2} {3} {4} {5} {6} {7}",mCreateAcc.Command, mCreateAcc.PhoneNumber, mCreateAcc.FirstName, mCreateAcc.LastName, mCreateAcc.Gender, mCreateAcc.Description, mCreateAcc.Age, mCreateAcc.Password);
                label5.Text = client.PostCreateAcc(mCreateAcc).GetAwaiter().GetResult();

                //move on to the next page
                this.Hide();
                MatchMaker mm = new MatchMaker(mCreateAcc.PhoneNumber);
                mm.ShowDialog();
                
            }
            else
            {
                label5.Text = "Please Fill all the boxes";
            }
        }
        //move to the previous page
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.ShowDialog();
        }
    }
}
