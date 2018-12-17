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
        // initialize necessary objects & variables
        private string id;
        MGetAll mGetAll = new MGetAll();
        Client client = new Client();
        PeopleInMatchList ppl = new PeopleInMatchList();
        string test = "";
        string[] users;


        public MatchList(String id)
        {
            InitializeComponent();

            //pass on the id with wich one logged in
            this.id = id;
            label3.Text = id;
            
        }
        // this method would have been used for a chat + interest function
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
            Console.WriteLine(e);

        }

        // retrieving all other users from the database
        private void button1_Click(object sender, EventArgs e)
        {
            mGetAll.Command = "GetAll";
            mGetAll.PhoneNumber = label3.Text;
            test = Client.PostGetAll(mGetAll).GetAwaiter().GetResult();
            users = test.Split(',');
            for (int i = 0; i < users.Length; i++)
            {
                listBox1.Items.Add(users[i]);
            }
        }

        // proceed to next window
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChatWindow cw = new ChatWindow();
            cw.ShowDialog();
        }

        // go back to previous window
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MatchMaker mm = new MatchMaker(id);
            mm.ShowDialog();
        }
    }
}
