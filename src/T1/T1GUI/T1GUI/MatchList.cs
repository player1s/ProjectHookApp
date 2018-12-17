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
        private string id;
        MGetAll mGetAll = new MGetAll();
        Client client = new Client();
        PeopleInMatchList ppl = new PeopleInMatchList();
        string test = "";


        public MatchList(String id)
        {
            InitializeComponent();
            this.id = id;
            label3.Text = id;
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
            Console.WriteLine(e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mGetAll.Command = "GetAll";
            test = Client.Post(mGetAll).GetAwaiter().GetResult();
            listBox1.Items.Add("");
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
            MatchMaker mm = new MatchMaker(id);
            mm.ShowDialog();
        }
    }
}
