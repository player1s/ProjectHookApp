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
    public partial class MatchList : Form
    {
        public MatchList()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Aelx");
            listBox1.Items.Add("Arif");
            listBox1.Items.Add("Levente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChatWindow cw = new ChatWindow();
            cw.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MatchMaker mm = new MatchMaker();
            mm.ShowDialog();
        }
    }
}
