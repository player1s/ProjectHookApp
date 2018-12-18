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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        
        //proceed to create account
        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount ca = new CreateAccount();
            ca.ShowDialog();
        }

        //proceed to login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
