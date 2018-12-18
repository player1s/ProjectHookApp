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
    public partial class ChatWindow : Form
    {
        private string id;
        public ChatWindow(String id)
        {
            InitializeComponent();
            this.id = id;
            label3.Text = id;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Console.WriteLine("goin back");
            this.Hide();
            MatchList mm = new MatchList(id, "please return to the \nmatch maker to set preferences", "", "");
            mm.ShowDialog();
        }

    }
}
