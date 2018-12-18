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
    public partial class MatchMaker : Form
    {
        private string id;
        private string gender;
        private string minage;
        private string maxage;
        public MatchMaker(String id)
        {
            InitializeComponent();
            this.id = id;
            label6.Text = id;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            minage = textBox1.Text ;
            maxage = textBox2.Text ;
            gender = textBox3.Text ;

            if (!(gender.Equals("m") || gender.Equals("f")))
                gender = "no preference set";

            if (!(IsDigitsOnly(minage)) || minage.Equals(""))
            {
                minage = "no preference set";
                Console.WriteLine("agepreference odified");
            }
            if (!(IsDigitsOnly(maxage)) || maxage.Equals(""))
                maxage = "no preference set";

            this.Hide();
            MatchList ml = new MatchList(id, gender, minage, maxage);
            ml.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
